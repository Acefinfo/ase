using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Cicle
{
    public class Shape
    {
        private int x;
        private int y;
        public Shape()
        {
        }
        public Shape(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }
        public int X
        {  	
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public void SetValues(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }

}
