using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }

        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            float square = 0;
            float minSquare = 0;
            float squWidth = 0;
            float squHeight = 0;
            float minWidth = 0;
            float minHeight = 0;
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        squWidth = rectAngle1.width + rectAngle2.width;
                        if (rectAngle1.height >= rectAngle2.height)
                        {
                            squHeight = rectAngle1.height;
                        }
                        else
                        {
                            squHeight = rectAngle2.height;
                        }
                        square = squWidth * squHeight;
                        break;
                    case 1:
                        squWidth = rectAngle1.width + rectAngle2.height;
                        if (rectAngle1.height >= rectAngle2.width)
                        {
                            squHeight = rectAngle1.height;
                        }
                        else
                        {
                            squHeight = rectAngle2.width;
                        }
                        square = squWidth * squHeight;
                        break;
                    case 2:
                        squWidth = rectAngle1.height + rectAngle2.width;
                        if (rectAngle1.width >= rectAngle2.height)
                        {
                            squHeight = rectAngle1.width;
                        }
                        else
                        {
                            squHeight = rectAngle2.height;
                        }
                        square = squHeight * squWidth;
                        break;
                    case 3:
                        squWidth = rectAngle1.height + rectAngle2.height;
                        if (rectAngle1.width >= rectAngle2.width)
                        {
                            squHeight = rectAngle1.width;
                        }
                        else
                        {
                            squHeight = rectAngle2.width;
                        }
                        square = squWidth * squHeight;
                        break;
                }
                if (minSquare >= square || minSquare == 0)
                {
                    minSquare = square;
                    minWidth = squWidth;
                    minHeight = squHeight;
                }
            }
            return new RectAngle(minWidth, minHeight);
        }
    }
}
