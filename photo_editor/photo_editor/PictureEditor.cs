using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photo_editor
{
    class PictureEditor
    {
        PictureBox pictureBox;
        Image img;
        Image oldPic; //старое фото
        Image originalPic; //оригинальное фото
        int crpX, crpY, rectW, rectH;

  

        public PictureEditor(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void Init(string fileName)
        {
            img = new Bitmap(fileName);
            oldPic = new Bitmap(fileName);

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = img;
            pictureBox.Invalidate();

        }

        public void ColorFilter(ColorMatrix color)
        {
            if (pictureBox.Image != null) // если изображение в pictureBox1 имеется
            {
                oldPic = img;
                Filter filter = new Filter();
               
                pictureBox.Image = filter.Apply(color, img);
            }
        }

        private Image ResizeImage(Image sourceImage, int scale)
        {
            var res = new Bitmap(sourceImage.Width / scale, sourceImage.Height / scale);
            using (var gr = Graphics.FromImage(res))
                gr.DrawImage(sourceImage, 0, 0, res.Width, res.Height);

            return res;
        }

        public void GrayColor()
        {
            ColorFilter(Filter.grayColor);
        }

        public void SepiaColor()
        {
            ColorFilter(Filter.sepiaColor);
        }

        public void BlueColor()
        {
            ColorFilter(Filter.blueColor);
        }

        public void YellowBlueColor()
        {
            ColorFilter(Filter.yellowBlueColor);
        }

        public void OriginalImage()
        {
            originalPic = img;
            pictureBox.Image = originalPic;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Invalidate();
        }

        public void SetSharp()
        {
            oldPic = img;
            pictureBox.Image = ResizeImage(oldPic, 20);
        }

        public void SaveImage()
        {
            if (pictureBox.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pictureBox.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            DeleteImage();
        }

        public void DeleteImage()
        {
            pictureBox.Image = null;
        }

        public void SelectCropArea(Control.ControlCollection Controls)
        {
            pictureBox.MouseDown += new MouseEventHandler(MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(MouseMove);
            pictureBox.MouseEnter += new EventHandler(MouseEnter);
            Controls.Add(pictureBox);
        }

        public void CropImage()
        {

            Cursor = Cursors.Default;
            //Здесь перерисовываем обрезанное изображение в pictureBox
            Bitmap bmp2 = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(bmp2, pictureBox.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            pictureBox.Image = (Image)crpImg;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            oldPic = crpImg;
        }

        public void MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox.Refresh();
                //устанавливаем ширину и высоту прямоугольника для обрезки 
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }
        // Объявляем перо для обрезки изображения 
        public Pen crpPen = new Pen(Color.White);

        public Cursor Cursor { get; private set; }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                // установить начальные координаты x, y для прямоугольника обрезки
                // здесь мы сначала нажимаем на изображение
                crpX = e.X;
                crpY = e.Y;

            }
        }
    }
}
