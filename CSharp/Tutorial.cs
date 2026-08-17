// C# Get Started
using System;
using System.Linq;

namespace CSharp
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Tutorials");
            Console.WriteLine();

            // 0. C# VARIABLES
            Console.WriteLine("0. C# Variables");
            int number = 7;
            Console.WriteLine();

            // 0.1 C# Constants (const variable store whole number, cannot be reassigned or change value)
            Console.WriteLine("0.1 C# Constants");
            const double myConst = 3.1415;
            Console.WriteLine();

            // 0.2 C# Display Variables (WriteLine() method is use to output (print) values )
            Console.WriteLine("0.2 C# Display Variables");
            Console.WriteLine("Number" + number);
            Console.WriteLine("Constant: " + myConst);
            Console.WriteLine("Using +" + number + myConst); // Use + to combine (string) or add (integers)
            Console.WriteLine();

            // 0.3 C# Multiple Variables (use comma-separated list)
            Console.WriteLine("0.3 C# Multiple Variables");
            int x = 1, y = 2, z = 3; // Multiple variable declaration in a single line
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
            Console.WriteLine();

            int a, b, c;
            a = b = c = 4; // Assign value in one line
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine();

            // 0.4 C# Identifier (Note: It is recommended to use descriptive names in order to create understandable and maintainable code)
            Console.WriteLine("0.4 C# Identifier");
            int minutesPerHour = 60; // minutePerHour is a variable name also called as identifiers
            int mph = 60; // Bad naming what does mph mean?
            Console.WriteLine("Good Variable Name minutePerHour: " + minutesPerHour);
            Console.WriteLine("Bad Variable Name mph: " + mph);
            Console.WriteLine();

            // 1. C# DATA TYPES (int, long, float, double, bool, char, string)
            Console.WriteLine("1. C# DATA TYPES");
            Console.WriteLine();

            // 1.1 Integer Types
            // 1.1.1 Int
            int myInt = 5; // integer variable store whole number | from -2,147,483,648 to 2,147,483,647
            Console.WriteLine("int data type: " + myInt);

            // 1.1.2 Long (Note that you should end the value with an "L")
            long myLong = 19L; // long variable type from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine("long data type: " + myLong);
            Console.WriteLine();

            // 1.2 Floating Point Types (Note that you should end the value with an "F" for floats and optional "D" for doubles)
            // 1.2.1 Float
            float myFloat = 0.123456F; // Up to 6 decimal digits 
            Console.WriteLine("float data type: " + myFloat);

            // 1.2.2 Double
            double myDouble = 0.15D; // Up to 15 decimal digits 
            Console.WriteLine("double data type: " + myDouble);

            // 1.2.3 Scientific Numbers ("e" to indicate the power of 10)
            float myFSciNum = 35e3F;
            double myDSciNum = 12e4;
            Console.WriteLine("35e3F: " + myFSciNum);
            Console.WriteLine("12e4D: " + myDSciNum);
            Console.WriteLine();

            // 1.3 Booleans (bool variable store "true" or "false" value)
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine("bool data type (isTrue): " + isTrue);
            Console.WriteLine("bool data type (isFalse): " + isFalse);
            Console.WriteLine();

            // 1.4 Characters (char variable store single character using single quotes ' ')
            char myChar = 'A';
            Console.WriteLine("char data type: " + myChar);
            Console.WriteLine();

            // 1.5 Strings (string variable store text using double quotes " ")
            string greeting = "Hello, World!";
            string message = "I'm Kel and this is my first C# program.";
            Console.Write("string data type: " + greeting); // Write prints text without moving to a new line
            Console.WriteLine(message); // WriteLine prints the text and then move to the next line
            Console.WriteLine();

            // 2. C# TYPE CASTING
            Console.WriteLine("2. C# TYPE CASTING");
            // 2.1 Implicit Casting (Implicit casting is done automatically when passing a smaller size type to a larger size type)
            // char -> int -> long -> float -> double
            double implicitCasting = myInt;
            Console.WriteLine("Implicit Casting: " + "int data type value: " + myInt + " => converted to double data type value: " + implicitCasting);

            // 2.2 Explicit Casting (Explicit casting must be done manually by placing the type in parentheses in front of the value)
            // double -> float -> long -> int -> char
            int explicitCasting = (int)myDouble;
            Console.WriteLine("Explicit Casting: " + "double data type value: " + myDouble + " => converted to int data type value: " + explicitCasting);
            Console.WriteLine();

            // 2.3 Type Conversion Methods (using built-in methods)
            // (Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long))
            Console.WriteLine(Convert.ToString(myInt) + " myInt is converted to a string");
            Console.WriteLine(Convert.ToDouble(myInt) + " myInt x is converted to a double");
            Console.WriteLine(Convert.ToInt32(myDouble) + " myDouble is converted to an int");
            Console.WriteLine(Convert.ToString(isTrue) + " bool (isTrue) is converted to a string");
            Console.WriteLine();

            // 3. C# USER INPUT (ReadLine() method is use to get user input)
            Console.WriteLine("3. C# USER INPUT");

            // 3.1 Get User Input
            Console.WriteLine("3.1 Get User Input");
            Console.WriteLine("Enter Your Name: ");
            string? yourName = Console.ReadLine(); // Include ? to allow null value if user doesn't input anything
            Console.WriteLine("Your Name: " + yourName);

            // 3.2 User Input and Numbers (ReadLine() returns a string and we need to convert it to integers)
            Console.WriteLine("3.2 User Input and Numbers");
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); // ToInt32() method is use to convert user input (string)
            Console.WriteLine("Your Age: " + age);
            Console.WriteLine();

            // 4. C# OPERATORS
            Console.WriteLine("4. C# OPERATORS");

            // 4.1 Arithmetic Operators (+, -, *, /, %, ++, --)
            Console.WriteLine("4.1 Arithmetic Operators");
            Console.WriteLine($"a: {a}, b: {b}"); // show values of a and b
            Console.WriteLine($"a + b: {a + b}"); // addition
            Console.WriteLine($"a - b: {a - b}"); // subtraction
            Console.WriteLine($"a * b: {a * b}"); // multiplication
            Console.WriteLine($"a / b: {a / b}"); // division
            Console.WriteLine($"a % 2: {a % 2}"); // modulus
            a++; // increment increase the value by 1
            Console.WriteLine($"a++: {a}"); // output
            b--; // decrement decrease the value by 1
            Console.WriteLine($"b--: {b}"); // output
            Console.WriteLine();

            // 4.2 Assignment Operators (=, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=)
            Console.WriteLine("4.2 Assignment Operators"); // Test Different Input
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"x += 7: {x += 7}"); // x = x + 7
            Console.WriteLine($"x -= 7: {x -= 7}"); // x = x - 7
            Console.WriteLine($"x *= 7: {x *= 7}"); // x = x * 7
            Console.WriteLine($"x /= 7: {x /= 7}"); // x = x / 7
            Console.WriteLine($"x %= 7: {x %= 7}"); // x = x % 3
            Console.WriteLine($"x &= 2: {x &= 2}"); // x = x & 2 bitwise AND
            Console.WriteLine($"x |= 2: {x |= 2}"); // x = x | 2 bitwise OR
            Console.WriteLine($"x ^= 2: {x ^= 2}"); // x = x ^ 2 bitwise XOR
            Console.WriteLine($"x >>= 2: {x >>= 2}"); // x = x >> 2 right shift
            Console.WriteLine($"x <<= 2: {x <<= 2}"); // x = x << 2 left shift
            Console.WriteLine();

            // 4.3 Comparison Operators (==, !=, >, <, >=, <=)
            Console.WriteLine("4.3 Comparison Operators"); // Test Different Input
            Console.WriteLine($"a: {x}, b: {y}"); // show values of a and b
            Console.WriteLine($"x == y: {x == y}"); // equal to
            Console.WriteLine($"x != y: {x != y}"); // not equal to
            Console.WriteLine($"x > y: {x > y}"); // greater than
            Console.WriteLine($"x < y: {x < y}"); // less than
            Console.WriteLine($"x >= y: {x >= y}"); // greater than or equal to
            Console.WriteLine($"x <= y: {x <= y}"); // less than or equal to
            Console.WriteLine();

            // 4.4 Logical Operators (&&, ||, !)
            Console.WriteLine("4.4 Logical Operators"); // Test Different Input
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"x < 5 && x < 10: {x < 5 && x < 10}"); // logical AND
            Console.WriteLine($"x < 5 || x < 10: {x < 5 || x < 10}"); // logical OR
            Console.WriteLine($"!isTrue: {!isTrue}"); // logical NOT
            Console.WriteLine();

            // 5. C# MATH (Math.Max, Math.Min, Math.Sqrt, Math.Abs, Math.Round)
            Console.WriteLine("5. C# MATH");
            Console.WriteLine("Math.Max(5, 10): " + Math.Max(5, 10));   // returns the highest of two numbers
            Console.WriteLine("Math.Min(5, 10): " + Math.Min(5, 10));   // returns the smallest of two numbers
            Console.WriteLine("Math.Sqrt(64): " + Math.Sqrt(64));       // returns the square root of a number
            Console.WriteLine("Math.Abs(-7): " + Math.Abs(-7));         // returns the absolute value of a number
            Console.WriteLine("Math.Round(9.99): " + Math.Round(9.99)); // returns the nearest integer)
            Console.WriteLine();

            // 6. C# STRING
            Console.WriteLine("6. C# STRING");

            // 6.1 Strings (Legth, ToLower(), ToUpper() methods)
            Console.WriteLine("6.1 Strings");
            string myString = "ABCDEFGHIJKLMnopqrstuvwxyz";
            Console.WriteLine("The Length of the String is: " + myString.Length); // returns the length of the string
            Console.WriteLine("myString: " + myString);
            Console.WriteLine(myString.ToLower()); // converts the string to lowercase
            Console.WriteLine(myString.ToUpper()); // converts the string to uppercase
            Console.WriteLine();

            // 6.2 Concatenation (Remember: Numbers are added while Strings are concatenated.)
            // 6.2.1 String Concatenation
            Console.WriteLine("6.2 Concatenation");
            string firstName = "Kel";
            string lastName = "Vinoya";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name using +: " + fullName);
            Console.WriteLine();

            // 6.2.2 Concat() method to concatenate two strings
            string name = string.Concat(firstName, lastName); // concatenates two strings
            Console.WriteLine("Full Name using .Concat(): " + name);
            Console.WriteLine();

            // 6.2.3 Adding Numbers 
            int d = 5, e = 10;
            Console.WriteLine($"d: {d} + e: {e} (Adding Numbers): {d + e}");

            // 6.2.4 Adding Strings
            string f = "5", g = "10";
            Console.WriteLine($"f: {f} + g: {g} (Adding Strings): {f + g}");
            Console.WriteLine();

            // 6.3 Interpolation (Use $ sign before the string to indicate that it is an interpolated string)
            Console.WriteLine("6.3 Interpolation");
            Console.WriteLine($"Full Name using Interpolation($): {firstName} {lastName}");
            Console.WriteLine();

            // 6.4 Access Strings (Note: String indexes start with 0: [0] is the first character. [1] is the second character, etc.)
            Console.WriteLine("6.4 Access Strings");

            // 6.4.1 Using [] to access a specific character in the string
            Console.WriteLine("Using []");
            Console.WriteLine($"firstName[0]: {firstName[0]}"); // returns the first character of the string
            Console.WriteLine($"firstName[1]: {firstName[1]}"); // returns the second character of the string
            Console.WriteLine($"firstName[2]: {firstName[2]}"); // returns the third character of the string
            // Console.WriteLine(firstName[3]); // returns the fourth character of the string System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            // 6.4.2 Using IndexOf() method to find the index of a specific character in the string
            Console.WriteLine("Using IndexOf() Method");
            Console.WriteLine($".IndexOf(\"e\") in firstName Kel is: {firstName.IndexOf("e")}"); // returns the index of the first occurrence of the specified character in the string

            // 6.4.3 Using .Substring() to extract a portion of the string
            Console.WriteLine("Using Substring Method");
            int charPosition = fullName.IndexOf("i");
            string lastNameSubstring = fullName.Substring(charPosition); // returns the substring starting from the specified index
            Console.WriteLine($"Substring starting from 'i': {lastNameSubstring}");

            // 6.5 Special Characters ( \', \", \\, \n, \t, \b )
            Console.WriteLine("6.5 Special Characters");
            Console.WriteLine("This is a string with special characters (single-quotes(')) using (\\'): It\'s a beautiful day!");
            Console.WriteLine("This is a string with special characters (double-quotes) using (\\\"): \"Hello World!\"");
            Console.WriteLine("This is a string with special characters (backslash) using (\\\\): The character \\ is called a backslash.");

            Console.WriteLine("This is a string with special characters (newline) using (\\n): Hello\n World!");
            Console.WriteLine("This is a string with special characters (tab) using (\\t): Hello\t World!");
            Console.WriteLine("This is a string with special characters (backspace) using (\\b): Hello\b World!");

            // 7. C# BOOLEANS
            Console.WriteLine("7. C# BOOLEANS");

            int myAge = 17; // Test different input
            int votingAge = 18;
            Console.WriteLine($"Am I applicable? {myAge >= votingAge}");
            Console.WriteLine();

            // 8. C# IF-ELSE STATEMENT (if, else, else if, short-hand if else (ternary operator))
            // 8.1 if (condition) {}
            Console.WriteLine("8. C# IF-ELSE STATEMENT");
            if (myAge >= votingAge) // Uppercase letters (If or IF) will generate an error.
            {
                Console.WriteLine("You are eligible to vote.");
            }

            // 8.2 else (condition) {}
            else // Specify a block of code to be executed if the condition is False
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            Console.WriteLine();

            // 8.3 else if (condition) {}
            Console.WriteLine("Else If Statement");
            int currentTime = 7; // Test different input

            if (currentTime >= 8 && currentTime < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (currentTime >= 12 && currentTime < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (currentTime >= 18 && currentTime < 24)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }

            Console.WriteLine();

            // 8.4 Short-hand if else (Ternary Operator) | Syntax variable = (condition) ? expressionTrue :  expressionFalse;
            Console.WriteLine("Short-hand if else | Ternary Operator");
            string eligibility = (myAge >= votingAge) ? "You are eligible to vote." : "You are not eligible to vote.";
            Console.WriteLine(eligibility);

            Console.WriteLine();

            // 9. C# SWITCH (Use the switch statement to select one of many code blocks to be executed)
            // switch (variable) { case 1: Output; break; ...}
            Console.WriteLine("9. C# SWITCH");
            Console.WriteLine("What day is it today? (1-7):");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: // Default condition if the input of day is not 1-7
                    Console.WriteLine("Up to 7 days in a week only.");
                    break;
            }

            Console.WriteLine();

            // 10. C# WHILE LOOP (Note: Do not forget to increase the variable used in the condition, otherwise the loop will never end!)
            // while (condiiton {} (while, do while) (LOOPING until false)
            Console.WriteLine("10. C# WHILE LOOP");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();

            // The Do/While Loop | do { } while (condition); (Loop until false)
            Console.WriteLine("10. C# DO/WHILE LOOP");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 10);

            Console.WriteLine();

            // 11. C# FOR LOOP (for (statement 1; statement 2; statement 3 {})
            Console.WriteLine("11. C# FOR LOOP");
            for (int k = 0; k < 5; k++) // (int k = 0; k <= 5; k = k+2)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();

            // 11.1 Nested Loops // It is also possible to place a loop inside another loop.
            Console.WriteLine("11.1.1 Nested Loops");
            for (int o = 0; o < 5; o++) // Outer Loop
            {
                Console.WriteLine("Outer Loop: " + o);
                for (int p = 0; p <= 5; p++) // Inner Loop
                {
                    Console.WriteLine("Inner Loop: " + p);
                }
            }

            Console.WriteLine();

            // 11.1 C# FOREACH LOOP (foreach (type variableName in arrayName) {})
            Console.WriteLine("11.1 C# FOREACH LOOP");
            string[] colors = { "Red", "Green", "Blue" };
            foreach (string q in colors)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine();

            // 12. C# BREAK AND CONTINUE STATEMENTS (break, continue)
            Console.WriteLine("12. C# BREAK AND CONTINUE STATEMENTS");

            // BREAK
            Console.WriteLine("BREAK");
            for (int r = 0; r < 10; r++)
            {
                if (r == 4) // condition
                {
                    break; // used to stop the loop
                }
                Console.WriteLine(r);
            }

            Console.WriteLine();

            // CONTINUE
            Console.WriteLine("CONTINUE");
            for (int s = 0; s < 10; s++)
            {
                if (s == 4) // condition
                {
                    continue; // used to skip the current iteration
                }
                Console.WriteLine(s);
            }

            Console.WriteLine();

            // Break in While Loop
            Console.WriteLine("Break in While Loop");
            int t = 0;
            while (t < 10)
            {
                Console.WriteLine(t);
                t++;
                if (t == 4)
                {
                    break;
                }
            }

            Console.WriteLine();

            // Continue in While Loop
            Console.WriteLine("CONTINUE in While Loop");
            int u = 0;
            while (u < 10)
            {
                if (u == 4)
                {
                    u++;
                    continue;
                }
                Console.WriteLine(u);
                u++;
            }

            Console.WriteLine();

            // 13. C# ARRAY // EXAMPLE: string[] colors;
            Console.WriteLine("C# ARRAY");
            // 13.1 C# Array
            Console.WriteLine("13.1 C# ARRAY");
            string[] colorsArray = { "Red", "Green", "Blue" }; // Declare and initialize an array using string variable
            int[] numbersArray = { 1, 2, 3, 4, 5 }; // Declare and initialize an array using int variable

            Console.WriteLine(colorsArray[2]); // Access Array Element | Index starts at 0
            Console.WriteLine(numbersArray[2]); // Access Array Element | Index starts at 0

            colorsArray[1] = "Yellow"; // Change Array Element
            Console.WriteLine(colorsArray[1]); // Check Changes

            Console.WriteLine(colorsArray.Length); // Get Array Length

            // OTHER WAYS // If you declare an array and initialize it later, you have to use the new keyword:
            /*
            // Create an array of four elements, and add values later
            string[] colorsArray = new string[3];

            // Create an array of four elements and add values right away 
            string[] colorsArray = new string[3] { "Red", "Green", "Blue" };

            // Create an array of four elements without specifying the size 
            string[] colorsArray = new string[] { "Red", "Green", "Blue" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] colorsArray = { "Red", "Green", "Blue" };

            // Note: If you declare an array and initialize it later, you have to use the new keyword
            // Declare an array
            string[] colorsArray;

            // Add values, using new
            colorsArray = new string[] {"Red", "Green", "Blue"};

            // Add values without using new (this will cause an error)
            colorsArray = {"Red", "Green", "Blue"};

            */

            Console.WriteLine();

            // 13.2 C# Loop Through an Arrays
            Console.WriteLine("13.2 C# Loop Through Arrays");
            for (int v = 0; v < colorsArray.Length; v++)
            {
                Console.WriteLine(colorsArray[v]);
            }

            Console.WriteLine();

            //13.2.1 C# Foreach Loop
            Console.WriteLine("13.2.1 C# Foreach Loop");
            foreach (string v in colorsArray)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            // 13.3 C# Sort Arrays
            Console.WriteLine("13.3 C# Sort Arrays");
            Console.WriteLine("13.3.1 C# Sort String Arrays");
            // Sort String
            Array.Sort(colorsArray);
            foreach (string v in colorsArray)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            // Sort Int
            Console.WriteLine("13.3.2 C# Sort Int Arrays");
            Array.Sort(numbersArray);
            foreach (int v in numbersArray)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            // System.Linq Namespace (see line 2)
            Console.WriteLine("13.3.3 C# System.Linq NameSpace");
            Console.WriteLine("numberArray.Max(): " + numbersArray.Max()); // returns the largest value
            Console.WriteLine("numberArray.Min(): " + numbersArray.Min()); // returns the smallest value
            Console.WriteLine("numberArray.Sum(): " + numbersArray.Sum()); // returns the sum of elements

            Console.WriteLine();

            // 13.4 C# Multidimensional Array
            Console.WriteLine("13.4 C# Multidimensional Array");
            int[,] MultiDArray = { { 1, 3, 5 }, { 2, 4, 6 } }; // 2D Array

            // 13.4.1 Access Elements of a 2D Array
            // Remember that: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.
            Console.WriteLine("13.4.1 Access Elements of a 2D Array");
            Console.WriteLine("MultiDArray[0, 2]: " + MultiDArray[0, 2]); // Output 5
            Console.WriteLine("MultiDArray[1, 2]: " + MultiDArray[1, 2]); // Output 6
            Console.WriteLine();

            // 13.4.2 Change Elements of a 2D Array
            Console.WriteLine("13.4.2 Change Elements of a 2D Array");
            MultiDArray[0, 0] = 7; // Change the first element to 7
            Console.WriteLine("New Array: " + MultiDArray[0, 0]); // Instead of 1 its 7 now
            Console.WriteLine();

            // 13.4.3 Foreach Loop Through a 2D Array
            Console.WriteLine("13.4.3 Foreach Loop Through a 2D Array");
            foreach (int v in MultiDArray)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            // 13.4.3.1 For Loop Through a 2D Array
            // Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:
            Console.WriteLine("13.4.3.1 For Loop Through a 2D Array");
            for (int v = 0; v < MultiDArray.GetLength(0); v++)
            {
                for (int w = 0; w < MultiDArray.GetLength(1); w++)
                {
                    Console.WriteLine(MultiDArray[v, w]);
                }
            }
        }
    }
}