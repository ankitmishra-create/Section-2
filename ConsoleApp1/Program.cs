using System;

class Operators
{
    public static void ArithmeticOperators()
    {
        //Arithemetic Operators
        int num1 = 10;
        int num2 = 20;
        int addedSum = num1 + num2;
        int subtractedSum = num1 - num2;
        int multipliedSum = num1 * num2;
        int dividedSum = num1 / num2;
        int modulusSum = num1 % num2;

        //Assignment Operators  
        int a = 10;
        a += 5; // a = a + 5
        a -= 3; // a = a - 3
        a *= 2; // a = a * 2
        a /= 4; // a = a / 4
        a %= 3; // a = a % 3

        //Increment and Decrement Operators
        a++; // Increment a by 1
        a--; // Decrement a by 1
        ++a; // Post Increment (increments before use)
        --a; // Post Decrement (decrements before use)

        //Comparison Operators
        if (num1 == num2) // Equal to
        {
            Console.WriteLine("num1 is equal to num2");
        }
        if (num1 != num2) // Not equal to
        {
            Console.WriteLine("num1 is not equal to num2");
        }
        if (num1 > num2) // Greater than
        {
            Console.WriteLine("num1 is greater than num2");
        }
        if (num1 < num2) // Less than
        {
            Console.WriteLine("num1 is less than num2");
        }
        if (num1 >= num2) // Greater than or equal to
        {
            Console.WriteLine("num1 is greater than or equal to num2");
        }
        if (num1 <= num2) // Less than or equal to
        {
            Console.WriteLine("num1 is less than or equal to num2");
        }

        //Logical Operators
        bool condition1 = true;
        bool condition2 = false;
        if (condition1 && condition2) // Logical AND
        {
            Console.WriteLine("Both conditions are true");
        }
        if (condition1 || condition2) // Logical OR
        {
            Console.WriteLine("At least one condition is true");
        }
        if (!condition1) // Logical NOT
        {
            Console.WriteLine("Condition1 is false");
        }

        //Bitwise Operators
        int bitwiseNum1 = 5; // 0101 in binary
        int bitwiseNum2 = 3; // 0011 in binary
        int bitwiseAnd = bitwiseNum1 & bitwiseNum2; // Bitwise AND
        int bitwiseOr = bitwiseNum1 | bitwiseNum2; // Bitwise OR
        int bitwiseXor = bitwiseNum1 ^ bitwiseNum2; // Bitwise XOR
        int bitwiseNot = ~bitwiseNum1; // Bitwise NOT
        int leftShift = bitwiseNum1 << 1; // Left shift
        int rightShift = bitwiseNum1 >> 1; // Right shift

        //Concatenation Operator
        string str1 = "Hello";
        string str2 = "World";
        string concatanedString = str1 + str2; // Concatenation of strings

        // Ternary Operator
        Console.WriteLine((num1>num2)? "num1 is greater than num2" : "num2 is greater than num1");



    }
}

class AreaOfCircle
{
    public static double numericalRadius;

    public static void SetRadius(string value)
    {
        numericalRadius = double.Parse(value);
    }

    public static double GetRadius()
    {
        return 3.14 * (numericalRadius) * (numericalRadius);
    }
}

class FeetToCentimeters
{
    public static double feetToCentimeters(double feet)
    {
        return feet * 30.48; // 1 foot = 30.48 centimeters
    }
}

class NearestThousand
{
    public static double RoundToNearestThousand(double number)
    {
        return Math.Round(number / 1000) * 1000;
    }
}

class SecondsToMinutes
{
    public static int SecondToMinute(int seconds)
    {
        return seconds / 60;
    }
}

class ConditionalControlStatement
{
    public static void Conditions()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 10){ 
            Console.WriteLine("Number is greater than 10");
        }
        else if (number == 10)
        {
            Console.WriteLine("Number is equal to 10");  
        }
        else
        {
            Console.WriteLine("Number is less than 10");
        }
    }

    public static void Heights(double data)
    {
        data = data * 2.54;
        if (data < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if(data >= 150 && data <= 165)
        {
            Console.WriteLine("Average Height");
        }
        else if(data >= 166 && data <= 195)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal Height");
        }
    }
    
}

class Switches
{
    public static int day;
    public static void SwitchExample()
    {
        day = Convert.ToInt32(Console.ReadLine());
        switch(day)
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
            default:
                Console.WriteLine("Invalid day");
                break;
        }

    }
}

class Loops
{
    public static void WhileLoop()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public static void DoWhileLoop()
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 5);
    }

    public static void ForLoop()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ForEachLoop()
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    public static void NestedLoop()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 2)
                {
                    break;
                }
                if (j == 3)
                {
                    continue;
                }
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }
    }
}

class Executable
{
    public static void Main()
    {
        Operators.ArithmeticOperators();
        AreaOfCircle.SetRadius("5");
        FeetToCentimeters.feetToCentimeters(10);
        NearestThousand.RoundToNearestThousand(123456.789);
        SecondsToMinutes.SecondToMinute(120);
        ConditionalControlStatement.Heights(75);
        Switches.SwitchExample();
        Loops.DoWhileLoop();

    }
}

