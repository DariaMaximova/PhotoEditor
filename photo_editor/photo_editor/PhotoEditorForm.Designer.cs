namespace photo_editor
{
    partial class PhotoEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sepia = new System.Windows.Forms.Button();
            this.shadesOfGray = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.original = new System.Windows.Forms.Button();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.greyBlue = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.crop2 = new System.Windows.Forms.Button();
            this.sharp = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sepia
            // 
            this.sepia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sepia.Location = new System.Drawing.Point(892, 371);
            this.sepia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sepia.Name = "sepia";
            this.sepia.Size = new System.Drawing.Size(109, 60);
            this.sepia.TabIndex = 3;
            this.sepia.Text = "Сепия";
            this.sepia.UseVisualStyleBackColor = false;
            this.sepia.Click += new System.EventHandler(this.SepiaColor_Click);
            // 
            // shadesOfGray
            // 
            this.shadesOfGray.BackColor = System.Drawing.SystemColors.HighlightText;
            this.shadesOfGray.Location = new System.Drawing.Point(1035, 371);
            this.shadesOfGray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shadesOfGray.Name = "shadesOfGray";
            this.shadesOfGray.Size = new System.Drawing.Size(107, 60);
            this.shadesOfGray.TabIndex = 2;
            this.shadesOfGray.Text = "Черно-белый";
            this.shadesOfGray.UseVisualStyleBackColor = false;
            this.shadesOfGray.Click += new System.EventHandler(this.GrayColor_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.blue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blue.FlatAppearance.BorderSize = 4;
            this.blue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.blue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blue.Location = new System.Drawing.Point(749, 371);
            this.blue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(110, 62);
            this.blue.TabIndex = 4;
            this.blue.Text = "Голубой";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.BlueColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(34, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // original
            // 
            this.original.BackColor = System.Drawing.SystemColors.HighlightText;
            this.original.Location = new System.Drawing.Point(745, 30);
            this.original.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(114, 62);
            this.original.TabIndex = 6;
            this.original.Text = "Оригинал";
            this.original.UseVisualStyleBackColor = false;
            this.original.Click += new System.EventHandler(this.OriginalImage_Click);
            // 
            // add_photo
            // 
            this.AddPhoto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddPhoto.FlatAppearance.BorderSize = 0;
            this.AddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPhoto.ForeColor = System.Drawing.Color.White;
            this.AddPhoto.Image = global::photo_editor.Properties.Resources.plus_PNG27;
            this.AddPhoto.Location = new System.Drawing.Point(299, 206);
            this.AddPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.AddPhoto.Name = "add_photo";
            this.AddPhoto.Size = new System.Drawing.Size(115, 114);
            this.AddPhoto.TabIndex = 1;
            this.AddPhoto.UseVisualStyleBackColor = false;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // greyBlue
            // 
            this.greyBlue.AutoSize = true;
            this.greyBlue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.greyBlue.Location = new System.Drawing.Point(749, 463);
            this.greyBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greyBlue.Name = "greyBlue";
            this.greyBlue.Size = new System.Drawing.Size(118, 62);
            this.greyBlue.TabIndex = 5;
            this.greyBlue.Text = "Желто-синий";
            this.greyBlue.UseVisualStyleBackColor = false;
            this.greyBlue.Click += new System.EventHandler(this.YellowBlueColor_Click);
            // 
            // crop
            // 
            this.crop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.crop.Location = new System.Drawing.Point(459, 614);
            this.crop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(107, 60);
            this.crop.TabIndex = 7;
            this.crop.Text = "Выбрать область";
            this.crop.UseVisualStyleBackColor = false;
            this.crop.Click += new System.EventHandler(this.SelectCropArea_Click);
            // 
            // crop2
            // 
            this.crop2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.crop2.Location = new System.Drawing.Point(598, 614);
            this.crop2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crop2.Name = "crop2";
            this.crop2.Size = new System.Drawing.Size(107, 60);
            this.crop2.TabIndex = 8;
            this.crop2.Text = "Обрезать";
            this.crop2.UseVisualStyleBackColor = false;
            this.crop2.Click += new System.EventHandler(this.CropImage_Click);
            // 
            // sharp
            // 
            this.sharp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sharp.Location = new System.Drawing.Point(745, 195);
            this.sharp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sharp.Name = "sharp";
            this.sharp.Size = new System.Drawing.Size(186, 60);
            this.sharp.TabIndex = 9;
            this.sharp.Text = " Уменьшить резкость";
            this.sharp.UseVisualStyleBackColor = false;
            this.sharp.Click += new System.EventHandler(this.SetSharp_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.HighlightText;
            this.text.Location = new System.Drawing.Point(231, 614);
            this.text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(107, 60);
            this.text.TabIndex = 10;
            this.text.Text = "Добавить ";
            this.text.UseVisualStyleBackColor = false;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(25, 637);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 12;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(315, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 13;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.HighlightText;
            this.save.Location = new System.Drawing.Point(894, 30);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(107, 60);
            this.save.TabIndex = 14;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label2.Location = new System.Drawing.Point(749, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Цветовые фильтры";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label3.Location = new System.Drawing.Point(461, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Обрезка фото";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(746, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Изменение резкости";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F);
            this.label5.Location = new System.Drawing.Point(30, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Добавить текст";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.delete.Location = new System.Drawing.Point(1035, 31);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(107, 60);
            this.delete.TabIndex = 19;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.DeleteImage_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::photo_editor.Properties.Resources.two_tone_blurred_background_6_big;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1179, 752);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.sharp);
            this.Controls.Add(this.crop2);
            this.Controls.Add(this.crop);
            this.Controls.Add(this.AddPhoto);
            this.Controls.Add(this.greyBlue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.original);
            this.Controls.Add(this.shadesOfGray);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.sepia);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фоторедактор";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button greyBlue;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Button original;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button shadesOfGray;
        private System.Windows.Forms.Button sepia;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button crop2;
        private System.Windows.Forms.Button sharp;
        private System.Windows.Forms.Button text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete;
    }
}

