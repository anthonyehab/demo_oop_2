using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_2.inhertince
{
    internal class child : parent
    {
      
        public int z { get; set; }

        public child(int X, int Y, int Z) : base(X,Y)

        {
            z = Z;
        }
        public override string ToString()
        {
            return $" {x},{y},{z}";

        }
        public new  int product()
        {

            return base.product()*z;
        }

    }
}



