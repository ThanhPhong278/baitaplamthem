using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class rectangle
    {
           private float length;
        private float width;
        public rectangle()
        {
            length = 1.0f;
            width = 1.0f;
        }
        public rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public float getLength()
        {
            return length;
        }
        public void setLength()
        {
            this.length = length;
        }
        public float getWidth()
        {
            return width;
        }
        public void setWidth(float width)
        {
            this.width = width;
        }
        public double getArea()
        {
            return length * width;
        }
        public double Perimeter()
        {
            return (length + width) * 2;
        }
        public override string ToString()
        {
            return String.Format("Rectangle[length = {0} , width = {1}", length, width);
           
        }
    }
}
    

