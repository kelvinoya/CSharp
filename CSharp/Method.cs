using System;

namespace CSharp
{
    class Method
    {
        // C# 1 METHODS
        // C# 1.1 Create a Method
        static void MyMethod() // Good practice to start with uppercase letter when naming methods.
        {
            Console.WriteLine("This is my Method aka Function");
        }

        // C# 2.1 Parameters and Arguments
        static void MethodParameters(string firstName) // Method with string parameters
        {
            Console.WriteLine(firstName + "Vinoya");
        }

        // C# 2.2 Multiple Parameters
        static void MultipleParameters(string firstName, string lastName, int age) // Can add many parameters, just separate using comma
        {
            Console.WriteLine($"{firstName} {lastName} is {age} years old.");
        }

        // C# 2.3 Default Parameter Value
        static void DefaultParameterValue(string country = "Philippines") // Parameter with a default value, is often known as an "optional parameter"
        {
            Console.WriteLine(country);
        }

        // C# 2.4 Return Values (void indicates that the method should not return a value)
        static int ReturnValues(int x) // Instead of using void, can use a primitive data type and use "return" keyword inside the method)
        {
            Console.Write("x: " + x);
            return 7 + x; // must return a value if it is not void
        }

        static int ReturnSum(int x, int y) // Multiple Parameters
        {
            Console.Write($"x: {x}, y: {y}");
            return x + y; // must return a value if it is not void
        }

        // C# 2.5 Named Arguments
        static void NamedArguments(string champ1, string champ2, string champ3) 
        {
            Console.WriteLine("Jungler Champion: " + champ2);
        }

        // C# Method Overloading
        static int SumMethod(int x, int y, int z)
        {
            Console.Write($"x: {x}, y: {y}, z: {z}");
            return x + y + z;
        }

        // Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.
        static double SumMethod(double x, double y, double z)  
        {
            Console.Write($"x: {x}, y: {y}, z: {z}");
            return x + y + z;
        }

        static void Main() // Main() is a C# pre-defined methods
        {
            // C# 1.2 Call a Method
            Console.WriteLine("C# 1 Methods");
            MyMethod(); // calling multiple times
            MyMethod();
            MyMethod();

            Console.WriteLine();

            Console.WriteLine("C# 2. Method Parameters");

            Console.WriteLine();

            // 2.1 Parameters and Arguments
            Console.WriteLine("C# 2.1 Parameters and Arguments"); // When a parameter is passed to the method, it is called an "argument".
            MethodParameters("Kel"); // firstName is parameter while "Kel" is an argument

            Console.WriteLine();

            // 2.2 Multiple Parameters
            Console.WriteLine("C# 2.2 Multiple Parameters");
            MultipleParameters("Michael", "Vinoya", 25); // Note that when you are working with multiple parameters,
            MultipleParameters("Kel", "Vinoya", 20); // the method call must have the same number of arguments as there are parameters.
            MultipleParameters("Mayk", "Vinoya", 15); // and the arguments must be passed in the same order.

            Console.WriteLine();

            // 2.3 Default Parameter Value
            Console.WriteLine("C# 2.3 Default Parameter Value");
            DefaultParameterValue(); // Can call method without argument (only work with default parameter value)
            DefaultParameterValue("South Korea");
            DefaultParameterValue("Japan");

            Console.WriteLine();

            // 2.4 Return Values
            Console.WriteLine("C# 2.4 Return Values");
            Console.WriteLine($" | 7 + x = {ReturnValues(1)}");
            Console.WriteLine();
            Console.WriteLine($" | x + y = {ReturnSum(5, 5)}");

            Console.WriteLine();

            // 2.5 Named Arguments
            Console.WriteLine("C# 2.5 Named Arguments");
            NamedArguments(champ1: "Lissandra", champ2: "LeeSin", champ3: "Oriannna"); // Using key: value syntax to send arguments
            NamedArguments(champ3: "Leblanc", champ2: "Naafiri", champ1: "Asol"); // The order of arguments does not matter

            Console.WriteLine();

            // 3 Method Overloading
            int myInt = SumMethod(1, 2, 3); // Must pass integer type
            Console.WriteLine(" | SumMethod() int type: " + myInt);
            Console.WriteLine();
            double myDouble = SumMethod(1.1, 2.2, 3.3); // Must pass floating type
            Console.WriteLine(" | SumMethod() double type: " + myDouble);


        }
    }
}
