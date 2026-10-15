using System;

namespace WPR.WindowsCompability.Media.Imaging
{
    public class WriteableBitmap
    {
        public int PixelWidth { get; }
        public int PixelHeight { get; }
        public int[] Pixels { get; }

        public WriteableBitmap(int pixelWidth, int pixelHeight)
        {
            if (pixelWidth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pixelWidth));
            }

            if (pixelHeight <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pixelHeight));
            }

            PixelWidth = pixelWidth;
            PixelHeight = pixelHeight;
            Pixels = new int[checked(pixelWidth * pixelHeight)];
        }

        public void Invalidate()
        {
        }
    }
}
