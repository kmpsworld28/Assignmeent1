using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculations
{
    class Calculate
    {
        //Private variable declarations.
        private int length, width;
        //Default constructor with default length and width of rectangle
        public Calculate()
        {
            length = 1;
            width = 1;
        }
        //Paramterized constructor to set values of length and width of the rectangle
        public Calculate(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        //public function returning the set length of the rectangle
        public int GetLength()
        {
            return this.length;
        }
        //public function setting length of the rectangle
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        //public function returning the set width of the rectangle
        public int GetWidth()
        {
            return this.width;
        }
        //public function setting width of the rectangle
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        //public function that returns perimter of the rectangle
        public int GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }
        //public function that returns area of the rectangle
        public int GetArea()
        {
            return (this.length * this.width);
        }
    }
}
