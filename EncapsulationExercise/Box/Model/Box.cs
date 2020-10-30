
using System;

namespace Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(Common.Common.InvalidSizeMessage, nameof(Length)));
                }
                length = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(Common.Common.InvalidSizeMessage, nameof(Width)));
                }
                width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(Common.Common.InvalidSizeMessage, nameof(Height)));
                }
                height = value;
            }
        }

        public double GetSurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public double GetLateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            return 2 * (Length * Height + Width * Height);
        }

        public double GetVolume()
        {
            //Volume = lwh
            return Length * Width * Height;
        }
    }
}
