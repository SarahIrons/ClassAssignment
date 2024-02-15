using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{//The static modifier in C# declares a static member of a class. The static modifier can be used with classes, properties, methods, fields, operators, events, and constructors, but it cannot be used with indexers, finalizers, or types other than classes.

    //A static class cannot be instantiated.All members of a static class are static and are accessed via the class name directly, without creating an instance of the class.
    // Creating static class
    // Using static keyword
    public static class StaticClass
    { 
        public static void StaticOnly(string Topic= "static class") =>
       // Accessing the static data members of StaticClass
       Console.WriteLine("Topic name is: " + Topic);
    }
}
    


