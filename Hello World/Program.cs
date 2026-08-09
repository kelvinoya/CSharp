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
            Console.WriteLine();

            // 6. C# STRING 
            Console.WriteLine("6.1 Strings"); // .Legth, .ToLower(), .ToUpper()
            string myString = "ABCDEFGHIJKLMnopqrstuvwxyz";
            Console.WriteLine("The Length of the String is: " + myString.Length); // returns the length of the string
            Console.WriteLine("myString: " + myString);
            Console.WriteLine(myString.ToLower()); // converts the string to lowercase
            Console.WriteLine(myString.ToUpper()); // converts the string to uppercase
            Console.WriteLine();

            Console.WriteLine("6.2 Concatenation"); // Remember: Numbers are added.Strings are concatenated.
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name using +: " + fullName);
            string name = string.Concat(firstName, lastName); // concatenates two strings
            Console.WriteLine("Full Name using .Concat(): " + name);
            int g = 5, h = 10;
            Console.WriteLine("g: " + g + " + h: " + h + " (int): " + (g + h));
            string m = "5", n = "10";
            Console.WriteLine("m: " + m + " + n: " + n + " (string): " + (m + n));
            Console.WriteLine();

            Console.WriteLine("6.3 Interpolation"); // Use $ sign before the string to indicate that it is an interpolated string
            Console.WriteLine($"Full Name using Interpolation($): {firstName} {lastName}");
            Console.WriteLine();

            // Note: String indexes start with 0: [0] is the first character. [1] is the second character, etc.
            Console.WriteLine("6.4 Access Strings");
            // Use [] to access a specific character in the string
            Console.WriteLine($"firstName[0]: {firstName[0]}"); // returns the first character of the string
            Console.WriteLine($"firstName[1]: {firstName[1]}"); // returns the second character of the string
            Console.WriteLine($"firstName[2]: {firstName[2]}"); // returns the third character of the string
                                                                // Console.WriteLine(firstName[3]); // returns the fourth character of the string System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            // Using .IndexOf() to find the index of a specific character in the string
            Console.WriteLine($".IndexOf(\"e\") in firstName Kel is: {firstName.IndexOf("e")}"); // returns the index of the first occurrence of the specified character in the string

            // Using .Substring() to extract a portion of the string
            int charPosition = fullName.IndexOf("i");
            string lastNameSubstring = fullName.Substring(charPosition); // returns the substring starting from the specified index
            Console.WriteLine($"Substring starting from 'i': {lastNameSubstring}");

            Console.WriteLine("6.5 Special Characters"); // ( \', \", \\, \n, \t, \b)
            Console.WriteLine("This is a string with special characters (single-quotes(')) using (\\'): It\'s a beautiful day!");
            Console.WriteLine("This is a string with special characters (double-quotes) using (\\\"): \"Hello World!\"");
            Console.WriteLine("This is a string with special characters (backslash) using (\\\\): The character \\ is called a backslash.");

            Console.WriteLine("This is a string with special characters (newline) using (\\n): Hello\nWorld!");
            Console.WriteLine("This is a string with special characters (tab) using (\\t): Hello\tWorld!");
            Console.WriteLine("This is a string with special characters (backspace) using (\\b): Hello\bWorld!");

            // 7. C# Booleans
            Console.WriteLine("7. C# Booleans");
            int myAge = 17; // Test different input
            int votingAge = 18;
            Console.WriteLine($"Am I applicable? {myAge >= votingAge}");
            Console.WriteLine();

            // 8. C# IF-ELSE STATEMENT (if, else, else if, short-hand if else (ternary operator))
            // if (condition) {}
            Console.WriteLine("8. C# IF-ELSE STATEMENT");
            if (myAge >= votingAge) // Uppercase letters (If or IF) will generate an error.
            {
                Console.WriteLine("You are eligible to vote.");
            }

            // else (condition) {}
            else // Specify a block of code to be executed if the condition is False
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            
            Console.WriteLine();

            // else if (condition) {}
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

            // short-hand if else (Ternary Operator) | Syntax variable = (condition) ? expressionTrue :  expressionFalse;
            Console.WriteLine("Ternary Operator");
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

            // do/while loop | do { } while (condition); (LOOPIGN until false)
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
            // Nested Loops // It is also possible to place a loop inside another loop.
            Console.WriteLine("Nested Loops");
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
            Console.WriteLine("BREAK in While Loop");
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
            // C# Array
            Console.WriteLine("13.1 C# ARRAY");
            string[] colorsArray = { "Red", "Green", "Blue" }; // Declare and initialize an array using string variable
            int[] numbersArray = { 1, 2, 3, 4, 5 }; // Declare and initialize an array using int variable
            
            Console.WriteLine(colorsArray[3]); // Access Array Element | Index starts at 0
            Console.WriteLine(numbersArray[2]); // Access Array Element | Index starts at 0

            colorsArray[1] = "Yellow"; // Change Array Element
            Console.WriteLine(colorsArray[1]); // Check Changes

            Console.WriteLine(colorsArray.Length); // Get Array Length

            // OTHER WAYS // If you declare an array and initialize it later, you have to use the new keyword:
            /*
            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            */

            Console.WriteLine();

            // C# Loop Through Arrays
            Console.WriteLine("13.2 C# Loop Through Arrays"); 
            for (int v = 0; v < colorsArray.Length; v++)
            {
                Console.WriteLine(colorsArray[v]);
            }

            /* 
            This
            is
            Multi-line
            Comment
            */
        }
    }
}