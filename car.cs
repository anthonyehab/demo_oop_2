using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_2
{
    internal class car
    {
        #region properties
        public int id { get; set; }
        public string model { get; set; }
        public double speed { get; set; }

        #endregion



        public override string ToString()
        {
            return $"car id :   {id}\n model   : {model}\n speed  :  {speed}";
        }



        public car()
        { }
        public car(int Id, string Model, double Speed)
        { 

            id=Id;  
            model=Model;
            speed=Speed;    
        }
        public car(int Id, string Model): this(Id,Model,190)
        {
           
        }
        public car(int Id) : this(Id,"audi",200)
        {
         
        }


    }
}
