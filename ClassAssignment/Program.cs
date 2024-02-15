using System;

namespace ClassAssignment
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Provide a number: ");

            {
                //creating object of class DivisionMethod
                DivisionMethod p = new DivisionMethod();
                p.DivNumber(); // Calling method

            }


            //            Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

            //In the Main() method, instantiate that class.

            //Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

            {
                //Create a method with output parameters
                ////creating object of class OutMethod
                OutMethod q = new OutMethod();
                q.AdditionUsingOut(); // Calling method

            }

            {
                // Overload a method.
                //Create a method with overload parameters
                ////creating object of class Overload
                Overload q = new Overload();
                //the function is called below and has the parameters in the lines below (integer and string respectively)
                q.Overloaded(12345);
                q.Overloaded("This is a line of text!");
                
            }

            {//Illustrating a static class
                //We call the static method by using class name followed by method. This is because you cannot instantiate new instance of a static method
                StaticClass.StaticOnly();
               
            }

               
      
        }


    }

}
