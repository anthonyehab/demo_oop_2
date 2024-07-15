using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_2.inhertince
{
    internal class parent
    {
        public int x { get; set; }
        public int y { get; set; }


        public parent(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int product()
        { 
        
        return x* y;    
        }
        public override string ToString()
        {
            return $" {x},{y} ";
        }
    }
}
