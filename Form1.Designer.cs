
namespace image_color_inversion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loadImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDisplay = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.oldColorDisplay = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newColorDisplay = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColorDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.picDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDisplay.Location = new System.Drawing.Point(29, 107);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(208, 187);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "⇄";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(265, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Инвертировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImage,
            this.saveImage});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // loadImage
            // 
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(73, 20);
            this.loadImage.Text = "Загрузить";
            // 
            // saveImage
            // 
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(78, 20);
            this.saveImage.Text = "Сохранить";
            // 
            // outputDisplay
            // 
            this.outputDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.outputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDisplay.Location = new System.Drawing.Point(556, 107);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(208, 187);
            this.outputDisplay.TabIndex = 5;
            this.outputDisplay.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(168, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(485, 45);
            this.title.TabIndex = 6;
            this.title.Text = "Инверсия цветов изображения";
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "openFileDialog1";
            // 
            // oldColorDisplay
            // 
            this.oldColorDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.oldColorDisplay.Location = new System.Drawing.Point(556, 312);
            this.oldColorDisplay.Name = "oldColorDisplay";
            this.oldColorDisplay.Size = new System.Drawing.Size(50, 50);
            this.oldColorDisplay.TabIndex = 7;
            this.oldColorDisplay.TabStop = false;
            this.oldColorDisplay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(638, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "⇄";
            // 
            // newColorDisplay
            // 
            this.newColorDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.newColorDisplay.Location = new System.Drawing.Point(714, 312);
            this.newColorDisplay.Name = "newColorDisplay";
            this.newColorDisplay.Size = new System.Drawing.Size(50, 50);
            this.newColorDisplay.TabIndex = 9;
            this.newColorDisplay.TabStop = false;
            this.newColorDisplay.Click += new System.EventHandler(this.newColorDisplay_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorButton.Location = new System.Drawing.Point(556, 382);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(208, 50);
            this.colorButton.TabIndex = 10;
            this.colorButton.Text = "Заменить";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.newColorDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldColorDisplay);
            this.Controls.Add(this.title);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Image Color Inversion";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColorDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadImage;
        private System.Windows.Forms.ToolStripMenuItem saveImage;
        private System.Windows.Forms.PictureBox outputDisplay;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.PictureBox oldColorDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox newColorDisplay;
        private System.Windows.Forms.Button colorButton;
    }
}

