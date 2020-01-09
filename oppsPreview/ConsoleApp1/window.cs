using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // a class represents the define characteristics of an item
    // an item can be a physical thing (cellphone), concept (student),
    // collection of data
    // visual studio creates your class whtihout a specified access type
    // the default type for a class is private
    // code outside of a private class cannot use the contents of the private class
    // for the class to be used by and outside user it must be public
   public class window
   {
        // the class can have data that is open to the used by
        // defining it as a public datatype variablename
        // the class can have data that is restircted from the user
        // by deffining it as a private data type variable
        // the class can create a property that can be used to 
        // interface between the user and the private data
        // the property will have public access

        // private data member
        // doesnt need a underscore, jsut there to define its private
        // because we will reuse the name
        private string _Manufacturer;

        // Properties
        // properties can be implemented in two ways
        // a) fully implemented property > used becuse there is additional code/logic used in processing the data
        // b) Auto implemented property > used when there is no need for additional code or logic
        //    the data is simplied saved

        public string Manufacturer
        {
            // assume the Manufacturer is a nullable string
            // 3 possiblities
            //  a) there are characters
            //  b) string has no data (null)
            //  c) there is a physical string but no characters (dont want this)
            // there will be additional code to ensure only a and b exsist
            // for the data
            // This requires a private data member to hold the data
            // and a property to manage the data content

            get
            {
                // returns data via the property to the outside user of propery
                return _Manufacturer;
            }

            set
            {
                // the set take incoming data and places that data
                // into the private data member

            }
        }

   }
}
