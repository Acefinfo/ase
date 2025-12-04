using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example2
{
    internal class Car:Vehicle
    {
        private string type;

        public Car() {}

        public Car(string manufacturer, string type) : base(manufacturer)
        {
            this.type = type;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public new string NameOf()
        {
            return base.NameOf() + " and it is a " + type;
        }
    }
}
