using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace image_color_inversion
{
    public class LockBitmap : IDisposable
    {
        private Bitmap bitmap;
        private BitmapData bitmapData;
        private bool locked = false;

        public LockBitmap(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        public int Width
        {
            get { return bitmap.Width; }
        }

        public int Height
        {
            get { return bitmap.Height; }
        }

        public void LockBits()
        {
            if (locked)
                return;

            // Lock the bitmap data
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            locked = true;
        }

        public void UnlockBits()
        {
            if (!locked)
                return;

            // Unlock the bitmap data
            bitmap.UnlockBits(bitmapData);
            locked = false;
        }

        public Color GetPixel(int x, int y)
        {
            if (!locked)
                throw new InvalidOperationException("Bitmap not locked");

            // Get the color of the specified pixel
            int offset = y * bitmapData.Stride + x * Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            byte b = Marshal.ReadByte(bitmapData.Scan0, offset);
            byte g = Marshal.ReadByte(bitmapData.Scan0, offset + 1);
            byte r = Marshal.ReadByte(bitmapData.Scan0, offset + 2);

            return Color.FromArgb(r, g, b);
        }

        public void SetPixel(int x, int y, Color color)
        {
            if (!locked)
                throw new InvalidOperationException("Bitmap not locked");

            // Set the color of the specified pixel
            int offset = y * bitmapData.Stride + x * Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            Marshal.WriteByte(bitmapData.Scan0, offset, color.B);
            Marshal.WriteByte(bitmapData.Scan0, offset + 1, color.G);
            Marshal.WriteByte(bitmapData.Scan0, offset + 2, color.R);
        }

        public void Dispose()
        {
            if (locked)
                UnlockBits();
        }
    }
}
