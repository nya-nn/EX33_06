using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(3, 5);
            RectAngle rectAngle2 = new RectAngle(5, 3);
            RectAngle rectAngle3 = rectAngle1 + rectAngle2;
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            Console.WriteLine($"2つの長方形が入る最小の長方形は横{rectAngle3.width},縦{rectAngle3.height}");
        }
    }
}
