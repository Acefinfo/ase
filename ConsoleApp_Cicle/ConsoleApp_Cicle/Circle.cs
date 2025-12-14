using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Cicle
{
    public class Circle : Shape
    {
        private double radius;
        public Circle()
        {

        }
        public Circle(int xValue, int yValue, double radiusIn)
        {
            
            X = xValue;
            Y = yValue;
            SetValues(xValue, yValue);  
            radius = radiusIn;
        }

        public void setData(int xValue, int yValue, double radiusIn)
        {
            SetValues(xValue, yValue);
            radius = radiusIn;

        }


    }



}
