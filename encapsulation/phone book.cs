using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_2.encapsulation
{
    internal struct phone_book
    {
        //        #region attributes
        //     private   string[] names;
        //     private   int[] numbers;
        //     private   int size;
        //        #region properties
        //        public int Size { get; }//read only  property
        //        #endregion
        //        #region constructor
        //        public phone_book(int size)
        //        {
        //            Size = size;
        //            names= new string[size];    
        //            numbers= new int[size]; 
        //         }

        //        #endregion
        //        #region methods
        //        public void addperson(int position, string personname, int phonenumber)
        //        {
        //            if (names is not null && numbers is not null)
        //            {
        //                if (position < size)
        //                {
        //                    names[position] = personname;
        //                    numbers[position] = phonenumber;
        //                }
        //            }

        //        }
        //        #endregion
        //        #region Getter - Setter

        //        //getter
        //        public int getpersonnumber(string personname)
        //        {
        //            if (names is not null && numbers is not null)
        //            {
        //                for (int i = 0; i < names.Length; i++)
        //                {
        //                    if (names[i] == personname)
        //                        return numbers[i];
        //                }

        //            }
        //            return -1;
        //        }

        //        //setter
        //        public void setpersonnumber(string personname, int newmumber)
        //        {
        //            if (names is not null && numbers is not null)
        //            {
        //                for (int i = 0; i < names.Length; i++)
        //                {
        //                    if (names[i] == personname)
        //                    { 
        //                    numbers[i] = newmumber;
        //                        break;
        //                    }

        //                }


        //            }

        //        }
        //        #endregion
        //        #region indexer
        //        //special property
        //        //1. named with keyword this
        //        //2. can take parameter

        //        public int this[string name]
        //        {
        //            get
        //            {
        //                if (names is not null && numbers is not null)
        //                {
        //                    for (int i = 0; i < names.Length; i++)
        //                    {
        //                        if (names[i] == name)
        //                            return numbers[i];
        //                    }

        //                }
        //                return -1;

        //            }

        //            set
        //            {
        //                if (names is not null && numbers is not null)
        //                {
        //                    for (int i = 0; i < names.Length; i++)
        //                    {
        //                        if (names[i] == name)
        //                        {
        //                            numbers[i] = value;
        //                            break;
        //                        }

        //                    }


        //                }

        //            }


        //        }

        //        public string this[int index]
        //        {
        //            get 
        //            {
        //                return $"{index}  :: {names[index]}  ::  {numbers[index]}"; 


        //            }


        //        }
        //        #endregion
        //        #endregion
        //    }
    }
}