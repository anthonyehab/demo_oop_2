using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_2.encapsulation
{
    internal struct employee
    {
        
        //public int id;
        //private string name;
        //public decimal salary;

        // encapsulation=> separate data defination [attributes]
        //from its use [getter  setter]
        #region 1.   apply encapsulation [getter  setter]
        // a. private attributes
        //b. two functions  [getter  setter]

        // getter  
        //public string getname()
        //{ 
        //return name;
        //}


        // setter
        //public void setname(string? value)    
        //{ 

        //name = value?.Length>5 ? value.Substring(0,5):value;
        
        //}
        #endregion
        #region  2.  apply encapsulation property
        //2.1 full property
        //2.2 automatic property
        //2.3 indexer
        //public decimal Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }

        //}

        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }


        //}
        //public int age { get; set; }
        #endregion


        
        #region constructors
        //public employee(int id, string name, decimal salary,int age)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //    this.age = age; 
        //}
        #endregion
        #region methods
        //public override string ToString()
        //{
        //    return $"id = {id}\n name ={name}\n salary = {salary}:c  ";
        //} 
        #endregion
    }
}
