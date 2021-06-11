using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();
            b1.SetLength(5.0);
            b1.SetBreadth(6.0);
            b1.SetHeight(7.0);
            b2.SetLength(10.0);
            b2.SetBreadth(12.0);
            b2.SetHeight(13.0);

            double v1 = b1.GetVolume();
            double v2 = b2.GetVolume();

            Console.WriteLine($"Volume of Box1: {v1}");
            Console.WriteLine($"Volume of Box2: {v2}");
            Console.ReadKey();
            Console.WriteLine();

            Box b3 = b1 + b2;
            Console.WriteLine($"Box3 is Box1 + Box2.");
            double v3 = b3.GetVolume();
            Console.WriteLine($"Volume of Box3: {v3}");
            Console.ReadKey();
            Console.WriteLine();

            Box b4 = b1 - b2;
            Console.WriteLine($"Box4 is Box2 - Box1.");
            double v4 = b4.GetVolume();
            Console.WriteLine($"Volume of Box3: {v4}");
            Console.ReadKey();
            Console.WriteLine();

            Box b5 = b1 * b2;
            Console.WriteLine($"Box4 is Box1 * Box2.");
            double v5 = b5.GetVolume();
            Console.WriteLine($"Volume of Box3: {v5}");
            Console.ReadKey();
            Console.WriteLine();

            Box b6 = b2 / b1;
            Console.WriteLine($"Box4 is Box2 / Box1.");
            double v6 = b6.GetVolume();
            Console.WriteLine($"Volume of Box3: {v6}");
            Console.ReadKey();
        }
    }
}
