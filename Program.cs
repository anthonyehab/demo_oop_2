using demo_oop_2.encapsulation;
using demo_oop_2.inhertince;
using System;
namespace demo_oop_2
{
    internal class program
    {

        static void main(string[] args)
        {
            #region encapsulation
            // employee employee= new employee(10,"tony",150000,99);
            //Console.WriteLine(employee);

            //employee.id = 20;
            //Console.WriteLine(employee.id);

            //employee.setname("ahmed");

            //employee.getname();
            //Console.WriteLine(employee.getname());

            //employee.Salary = 3000;
            //Console.WriteLine(employee.Salary);

            #endregion
            #region index

            //phone_book note = new phone_book(3);

            //note.addperson(0, "tony", 123);
            //note.addperson(1, "mona", 456);
            //note.addperson(2, "ehab", 789);


            //int phonenumber = note.getpersonnumber("tony");

            //Console.WriteLine(phonenumber==-1 ? "not found" : phonenumber);

            //note.setpersonnumber("mona", 999);

            //Console.WriteLine(note.getpersonnumber("mona"));


            //note["ehab"] = 666;
            //Console.WriteLine(note["ehab"]);

            #endregion
            #region class
            //car c1;
            //c1 = new car();

            //car c1 = new car(10,"bmw",120);
            // Console.WriteLine(c1);

            // car c2 = new car(20,"byd");
            // Console.WriteLine(c2);

            // car c3 = new car(30);
            // Console.WriteLine(c3);

            #endregion
            #region inheritance
            //parent p = new parent(1,2);
            //Console.WriteLine($"p  = {p}");
            //Console.WriteLine($"product = {p.product()}");


            //child c = new child(3, 4, 5);
            //Console.WriteLine($"c = {c}");
            //Console.WriteLine($"product = {c.product()}"); 
            #endregion

        }





    }


}