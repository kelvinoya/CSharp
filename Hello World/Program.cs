using System;

namespace Hello_World
{
    class FirstProgram
    {
        static void Main(string[] args)
        {
            // 1. C# DATA TYPES (int, long, double, float, char, string, bool)
            int x = 10; // integer variable store whole number | from -2,147,483,648 to 2,147,483,647
            // long x = 19L; // long variable type from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 use L suffix to indicate long type
            // const int x = 10; // constant variable store whole number, cannot be reassigned
            // x = 20; // reassigning the value of x to 20
            
            double y = 0.15; // double variable store decimal number | up to 15 decimal digits | optional use D suffix to indicate double type

            int a = 1, b = 2, c = 3; // multiple variable declaration in a single line
            int d, e;
            d = e = 4;
            
            float f = 0.123456F; // up to 6 decimal digits | use F suffix to indicate float type 

            char singleCharacter = 'A'; // char variable store single character using single quotes

            string greeting = "Hello, World! "; // string variable store text using double quotes
            string message = "I'm Kel and this is my first C# program.";

            string firstName = "Kel"; // name of the variable is called Identifier
            string lastName = "Vinoya"; // Note: It is recommended to use descriptive names in order to create understandable and maintainable code

            bool isTrue = true; // bool variable store true or false value
            bool isFalse = false;

            // 2. C# TYPE CASTING | Use for compatibility issue
            double doubleValue = x; // Implicit Casting | converting int to double

            int intValue = (int)y; // Explicit Casting | converting double to int

            // OUTPUT
            Console.WriteLine("1. C# DATA TYPES");
            Console.Write("String: " + greeting); // This is a Single-Line Comment | use Write if you want to print text without a new line
            Console.WriteLine(message); // WriteLine will print the text and move to the next line
            Console.WriteLine("Int: " + x + y); // concatenation using + operator
            Console.WriteLine("Char: " + singleCharacter);
            Console.WriteLine(firstName + " " + singleCharacter + ". " + lastName);
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("a + b - c: " + (a + b - c));
            Console.WriteLine("d: " + d);
            Console.WriteLine("e: " + e);
            Console.WriteLine("f: " + f);
            Console.WriteLine("d + e + f: " + (d + e + f));
            Console.WriteLine("Bool (isTrue): " + isTrue);
            Console.WriteLine("Bool (isFalse): " + isFalse);
            Console.WriteLine();

            Console.WriteLine("2. C# TYPE CASTING");
            /* 
            Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double
            */
            Console.WriteLine("Implicit Casting: " + "int data type value: " + x + " => converted to double data type value: " + doubleValue);
            /*
            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char
            */
            Console.WriteLine("Explicit Casting: " + "double data type value: " + y + " => converted to int data type value: " + intValue);

            // Type Conversion using built-in methods 
            // (Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):)
            Console.WriteLine(Convert.ToString(x) + " int x is now a string");
            Console.WriteLine(Convert.ToDouble(x) + " int x is now a double");
            Console.WriteLine(Convert.ToInt32(y) + " double y is now an int");
            Console.WriteLine(Convert.ToString(isTrue) + " bool isTrue is now a string");
            Console.WriteLine();

            // 3. C# USER INPUT | Use Console.ReadLine() to get user input from the console
            Console.WriteLine("3. C# USER INPUT");
            Console.WriteLine("Enter your name: ");

            string? userName = Console.ReadLine(); // Include ? to allow null value if user doesn't input anything

            Console.WriteLine("Your Name: " + userName);

            Console.WriteLine("Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine() returns a string and we need to convert it to int

            Console.WriteLine("Your Age: " + age);
            Console.WriteLine();

            // 4. C# OPERATORS
            Console.WriteLine("4. C# OPERATORS");

            //  Arithmetic Operators (+, -, *, /, %, ++, --)
            Console.WriteLine("4.1 Arithmetic Operators");
            Console.WriteLine(x + y); // addition
            Console.WriteLine(x - y); // subtraction
            Console.WriteLine(x * y); // multiplication
            Console.WriteLine(x / y); // division
            Console.WriteLine(x % 2); // modulus
            x++; // increment
            Console.WriteLine(x); // output
            x--; // decrement
            Console.WriteLine(x); // output
            Console.WriteLine();

            // Assignment Operators (=, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=)
            Console.WriteLine("4.2 Assignment Operators");
            // Test different input 
            Console.WriteLine("x += 7: " + (x += 7)); // x = x + 7
            Console.WriteLine("x -= 7: " + (x -= 7)); // x = x - 7
            Console.WriteLine("x *= 7: " + (x *= 7)); // x = x * 7
            Console.WriteLine("x /= 7: " + (x /= 7)); // x = x / 7
            Console.WriteLine("x %= 7: " + (x %= 7)); // x = x % 3
            Console.WriteLine("x &= 2: " + (x &= 2)); // x = x & 2 bitwise AND
            Console.WriteLine("x |= 2: " + (x |= 2)); // x = x | 2 bitwise OR
            Console.WriteLine("x ^= 2: " + (x ^= 2)); // x = x ^ 2 bitwise XOR
            Console.WriteLine("x >>= 2: " + (x >>= 2)); // x = x >> 2 right shift
            Console.WriteLine("x <<= 2: " + (x <<= 2)); // x = x << 2 left shift
            Console.WriteLine();

            // Comparison Operators (==, !=, >, <, >=, <=)
            Console.WriteLine("4.3 Comparison Operators");
            x = 10; // reset x to 10
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);   
            Console.WriteLine("x == y: " + (x == y)); // equal to
            Console.WriteLine("x != y: " + (x != y)); // not equal to
            Console.WriteLine("x > y: " + (x > y)); // greater than
            Console.WriteLine("x < y: " + (x < y)); // less than
            Console.WriteLine("x >= y: " + (x >= y)); // greater than or equal to
            Console.WriteLine("x <= y: " + (x <= y)); // less than or equal to
            Console.WriteLine();

            // Logical Operators (&&, ||, !)
            Console.WriteLine("4.4 Logical Operators");
            x = 10; // reset x to 10
            Console.WriteLine("x: " + x);
            Console.WriteLine("x < 5 && x < 10: " + (x < 5 && x < 10)); // logical AND
            Console.WriteLine("x < 5 || x < 10: " + (x < 5 || x < 10)); // logical OR
            Console.WriteLine("!isTrue: " + (!isTrue)); // logical NOT
            Console.WriteLine();

            // 5. C# MATH (Math.Max, Math.Min, Math.Sqrt, Math.Abs, Math.Round)
            Console.WriteLine("5. C# MATH");
            Console.WriteLine("Math.Max(5, 10): " + Math.Max(5, 10));   // returns the highest of two numbers
            Console.WriteLine("Math.Min(5, 10): " + Math.Min(5, 10));   // returns the smallest of two numbers
            Console.WriteLine("Math.Sqrt(64): " + Math.Sqrt(64));       // returns the square root of a number
            Console.WriteLine("Math.Abs(-7): " + Math.Abs(-7));         // returns the absolute value of a number
            Console.WriteLine("Math.Round(9.99): " + Math.Round(9.99)); // returns the nearest integer)

            // 6. C# STRINGS
            Console.WriteLine("6.1 Strings");


            Console.WriteLine("6.2 Concatenation");


            Console.WriteLine("6.3 Interpolation");


            Console.WriteLine("6.4 Access Strings");


            Console.WriteLine("6.5 Special Characters");

            // 

            /* 
            This
            is
            Multi-line
            Comment
            */
        }
    }
}