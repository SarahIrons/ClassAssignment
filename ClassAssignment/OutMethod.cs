using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class OutMethod
    {
        public void AdditionUsingOut()
        {

            // Declaring variable
            // without assigning value
            int a;

            // Pass variable a to the method
            // using out keyword
            AdditionUsingOut(out a);

            // Display the value a
            Console.WriteLine("Adding 20 incrementally to a predetermined base value is: {0}", a);
        }

        // Method in which out parameter is passed
        // and this method returns the value of 
        // the passed parameter
        public static void AdditionUsingOut(out int a)
        {
            a = 20;
            a += a;
        }
    }
}

