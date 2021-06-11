using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        double length;
        double breadth;
        double height;

        public double GetVolume()
        {
            return length * breadth * height;
        }

        public void SetLength(double len)
        {
            length = len;
        }

        public void SetBreadth(double bre)
        {
            breadth = bre;
        }

        public void SetHeight(double hei)
        {
            height = hei;
        }

        public static Box operator+ (Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.breadth = a.breadth + b.breadth;
            box.height = a.height + b.height;
            return box;
        }

        public static Box operator* (Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length * b.length;
            box.breadth = a.breadth * b.breadth;
            box.height = a.height * b.height;
            return box;
        }

        public static Box operator- (Box a, Box b)
        {
            Box box = new Box();
            if (a.length > b.length && a.height > b.height && a.breadth > b.breadth)
            {
                box.length = a.length - b.length;
                box.breadth = a.breadth - b.breadth;
                box.height = a.height - b.height;
                return box;
            }
            else
            {
                Console.WriteLine("The dimensions of the first box are less than those of the second box. Try other boxes.");
                return box;
            }

        }

        public static Box operator/ (Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length / b.length;
            box.breadth = a.breadth / b.breadth;
            box.height = a.height / b.height;
            return box;
        }
    }
}
