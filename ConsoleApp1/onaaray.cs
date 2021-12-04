using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class onaaray
    {
        static void Main(string[] args)
        {
            int hey;
            bool op;
            string bib;

            string[] names = new string[] { "Bibas", "Ashwin", "Aakash", "Chandan" };
            Console.WriteLine(names.Length);




            /* foreach (var item in names)                           //using for each loop 
             {
                 Console.WriteLine(item);
             }*/






            // TODO:this is to resize for array                           //for  resize for array 
            /* Array.Resize(ref names, names.Length +2);
             names[4] = "rijwan";
             names[5] = "nabin";*/






            // TODO:this is to find index number of array               //For find index of item
            /* hey= Array.IndexOf(names, " Aakash");
             Console.WriteLine("The indexof  akash is " + hey);*/






            //  TODO:This case for reverse                          //for reverse
            /* Array.Reverse(names);*/







            // TODO: for Array.Exists
            /*op= Array.Exists(names, name => name.Contains("A"));    // In Array.Exist return boolean value 
             Console.WriteLine(op);*/



            // TODO: for Array.Find
            /*  bib= Array.Find(names, name => name.Contains("h"));    // In Array.Find return name "h"
              Console.WriteLine(bib);*/




            // TODO: for Array.FindALL
            /*  bib= Array.FindAll(names, name => name.Contains("h"));    // In Array.FindAll return name "h" item
              Console.WriteLine(bib);*/






            /* for (int i = 0; i < names.Length; i++)                        //using for loop 
             {
                 Console.WriteLine(names[i]);
             }*/




            Console.ReadLine();
        }
    }
}
