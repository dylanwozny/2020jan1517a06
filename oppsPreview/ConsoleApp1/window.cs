﻿using System;
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

        //------------- private data member-------
        // doesnt need a underscore, jsut there to define its private
        // because we will reuse the name
        // USED FOR fully implemented properties

        // program.cs is an outside user and cannot access private _manufacturer
        // program.cs goes through properties to access
        private string _Manufacturer;
        private decimal _Height;
        

        // Properties
        // properties can be implemented in two ways
        // a) fully implemented property > used becuse there is additional code/logic used in processing the data
        // b) Auto implemented property > used when there is no need for additional code or logic
        //    the data is simplied saved 

        //-----------FULLY IMPLEMENTED PROPERTY----------------------
        // need additional logic

        // you can code a auto implemented property as a fully implemented property.

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
                // returns private value of _manufacturer to program.cs or outside program
                // right side of assigment property

                // flow of information
                //  private >>>>>>>> public
                return _Manufacturer;
            }

            set
            {
                // the set take incoming data and places that data
                // into the private data member
                // left side of an assignment statement

                // flow of information
                // private <<<<<<<<< public

                // internal to the property incoming data 
                // while be placed in a common variable called value

                // if string has no empty values, put into common property called value
                // a property  is associated with a single data member
                // a property has no parameter list
                if (string.IsNullOrEmpty(value))
                {
                    // null value is no data
                    _Manufacturer = null;

                }

                else
                {
                    // else there is no emptyness or value, assign value to _manufacturer
                    // assigment statement  
                    _Manufacturer = value;

                }

                // alternate code
                // ternary operator
                // can only assign to one variable
                //_Manufacturer = string.IsNullOrEmpty(value) ? null : value;

            }
        }

        public decimal Height
        {

            get
            {
                return _Height;
            }

            set
            {
                // the m indicated if the value is a decimal
                if (value <= 0.0m)
                {
                    throw new Exception("Height cannot be zero or less");
                }

                else
                {
                    _Height = value;
                }
            }
        }


        //-------------AUTO IMPPLEMETED PROPERTY-----------------------------
        // no additional logic

        // auto implemented properties can be used when there
        // is NO NEED for additional processing against the incoming data
        // no internal private data member required for this property
        // the system will internally generate a data area for the data
        // access this the stored data (getting or setting) can only be done via the property
        public decimal Width { get; set; }



        // why do we not need to fully implement a nullable numeric ?
        // Numerics have a default of zero.
        // Numerics can only store a numeric (unless nullable)
        // numerics can be null if declared as nullable
        // can either store a number or null
        // IF the numeric has additional criteria then you can use a fully implemented property
        public int? NumberOfPanes { get; set; }

   }
}
