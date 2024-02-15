using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class DivisionMethod
    {
        public void DivNumber()
        
            { //Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.
            //Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
                 int inputNumber = Convert.ToInt32(Console.ReadLine());
              //this converts the string from user input into an integer to be put into the division question (divide by two)
                Console.WriteLine("Your number divided by two is:" + inputNumber / 2);
            }

    }
}
