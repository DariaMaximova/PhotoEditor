using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace photo_editor
{
    public partial class PhotoEditorForm : Form
    {
        private PictureEditor pictureEditor;
        private void InitPictureBox()
        {
            pictureEditor = new PictureEditor(pictureBox1);
        }

        public PhotoEditorForm()
        {
            InitializeComponent();
            InitPictureBox();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            //Bitmap img;
            OpenFileDialog newPhoto = new OpenFileDialog();
            newPhoto.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)" + // текстовое представление(выбор формата в строке)
                "|*.BMP;*.JPG;*.GIF;*.PNG" + //(для отображения файлов только нужных)
                "|All files(*.*)" + // текстовое представление 
                "|*.*"; //любой файл

            if (newPhoto.ShowDialog() == DialogResult.OK) //если в диалоговом окне выбрали "ОК"
            {
                try
                {
                    pictureEditor.Init(newPhoto.FileName);
                    //делаем невидимой кнопку после добавления фото(плюсик)
                    AddPhoto.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить файл!", "Ошибка", // сообщение об ошибке 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void GrayColor_Click(object sender, EventArgs e)
        {
            pictureEditor.GrayColor();
        }
        private void SepiaColor_Click(object sender, EventArgs e)
        {
            pictureEditor.SepiaColor();
        }
        private void BlueColor_Click(object sender, EventArgs e)
        {
            pictureEditor.BlueColor();
        }
        private void YellowBlueColor_Click(object sender, EventArgs e)
        {
            pictureEditor.YellowBlueColor();
        }
        private void OriginalImage_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            pictureEditor.OriginalImage();
        }

        //обрезка фото
        private void SelectCropArea_Click(object sender, EventArgs e)
        {
            pictureEditor.SelectCropArea(Controls);
        }

        private void CropImage_Click(object sender, EventArgs e)
        {
            pictureEditor.CropImage();
        }
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            pictureEditor.MouseEnter(sender, e);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            pictureEditor.MouseMove(sender, e);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            pictureEditor.MouseDown(sender, e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        //изменение резкости фото
        private void SetSharp_Click(object sender, EventArgs e)
        {
            pictureEditor.SetSharp();

        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            pictureEditor.SaveImage();
            AddPhoto.Visible = true;
        }

       

        private void DeleteImage_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            pictureEditor.DeleteImage();
            AddPhoto.Visible = true;
           
        }


        //добавление текста к фото
        private void text_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
