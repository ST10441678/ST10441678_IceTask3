using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10441678_IceTask3
{
   abstract class Shape
    {
        protected String Name;
        public Shape(String Name)
        {
            this.Name = Name;
        }

        public String getName()
        {
            return Name;
        }

        public abstract void Display();

    }
}
