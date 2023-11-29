using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_color_inversion
{

    public partial class Form1 : Form
    {
        // private OpenFileDialog ofdLoad; // Declare the OpenFileDialog

        public Form1()
        {
            InitializeComponent();

            // Initialize the OpenFileDialog
            ofdLoad = new OpenFileDialog();
            ofdLoad.Filter = "Image Files|*.jpg;*.jpeg;*.bmp|Inverted images|*.inv";

       
            // Attach the Click event handler for the menu item during the form initialization
            loadImage.Click += LoadImage_Click;
            saveImage.Click += SaveImage_Click;
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image imgSource = Image.FromFile(ofdLoad.FileName);
                    int originalHeight = imgSource.Height;
                    int originalWidth = imgSource.Width;
                    Console.Write(originalHeight.ToString(), originalWidth.ToString());
                    picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDisplay.Image = imgSource;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image");
                }
            }
        }

        private static Image InvertGDI(Image imgSource)
        {
            Bitmap bmpDest = null;

            using (Bitmap bmpSource = new Bitmap(imgSource))
            {
                bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

                for (int x = 0; x < bmpSource.Width; x++)
                {
                    for (int y = 0; y < bmpSource.Height; y++)
                    {

                        Color clrPixel = bmpSource.GetPixel(x, y);

                        clrPixel = Color.FromArgb(255 - clrPixel.R, 255 -
                           clrPixel.G, 255 - clrPixel.B);

                        bmpDest.SetPixel(x, y, clrPixel);
                    }
                }
            }

            return (Image)bmpDest;

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (picDisplay.Image != null)
                outputDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                outputDisplay.Image = InvertGDI(picDisplay.Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog oldColor = new ColorDialog();
            if (oldColor.ShowDialog() == DialogResult.OK)
            {
                oldColorDisplay.BackColor = oldColor.Color; 
            }
        }

        private void newColorDisplay_Click(object sender, EventArgs e)
        {
            ColorDialog newColor = new ColorDialog();
            if (newColor.ShowDialog() == DialogResult.OK)
            {
                newColorDisplay.BackColor = newColor.Color;
            }
        }

        private static void SwapColor(Bitmap bmp, Color oldColor, Color newColor, int tolerance = 25)
        {
            using (var lockedBitmap = new LockBitmap(bmp))
            {
                lockedBitmap.LockBits();

                for (int y = 0; y < lockedBitmap.Height; y++)
                {
                    for (int x = 0; x < lockedBitmap.Width; x++)
                    {
                        Color currentColor = lockedBitmap.GetPixel(x, y);

                        if (ColorMatch(currentColor, oldColor, tolerance))
                        {
                            lockedBitmap.SetPixel(x, y, newColor);
                        }
                    }
                }

                lockedBitmap.UnlockBits();
            }
        }

        private static bool ColorMatch(Color c1, Color c2, int tolerance)
        {
            // Check if the RGB values are within the tolerance range
            return Math.Abs(c1.R - c2.R) <= tolerance &&
                   Math.Abs(c1.G - c2.G) <= tolerance &&
                   Math.Abs(c1.B - c2.B) <= tolerance;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            // Check if both oldColor and newColor are selected
            if (oldColorDisplay.BackColor != Color.Empty && newColorDisplay.BackColor != Color.Empty)
            {
                // Check if the outputDisplay has an image
                if (outputDisplay.Image != null)
                {
                    // Get the Bitmap from the outputDisplay image
                    Bitmap outputBitmap = new Bitmap(outputDisplay.Image);

                    // Get the old and new colors
                    Color oldColor = oldColorDisplay.BackColor;
                    Color newColor = newColorDisplay.BackColor;

                    // Call the SwapColor method to replace oldColor with newColor
                    SwapColor(outputBitmap, oldColor, newColor);

                    // Update the outputDisplay image with the modified Bitmap
                    outputDisplay.Image = outputBitmap;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, загрузите изображение.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите оба цвета.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"Inverted images|*.inv" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputDisplay.Image.Save(saveFileDialog.FileName);
                }
            }
        }
      
        
}
    }
