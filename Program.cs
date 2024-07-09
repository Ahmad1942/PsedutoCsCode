using System;
using System.ComponentModel.Design;

namespace Assignment1PseduToCsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Question 1
            Console.Write("Enter You FirstNumber");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Your SecondNumber");
            int SecondNumber = int.Parse(Console.ReadLine());
            SumOfTwoInteger(FirstNumber, SecondNumber);

            // Question 2
            EvenNumberPrinting(100);


            // Question 3
            Console.WriteLine("Please Enter Year");
            int UserInput = int.Parse(Console.ReadLine()); 
            LeapYearChecker(UserInput);
            // Question 4
            Console.WriteLine("Enter Kilometer Per Hour");
            int Kmh = int.Parse(Console.ReadLine());
            KmhToMphConversion(Kmh);

            // Question 5
            Console.WriteLine("Enter Your Number");
            int UserNumber = int.Parse(Console.ReadLine());
            BuzzNumberFinder(UserNumber);

            // Question 6
            Console.WriteLine("Enter Table Number");
            int TableNumber = int.Parse(Console.ReadLine());
            TablePrinting(TableNumber);

            // Question 7
            Console.WriteLine("Enter a Number for Factorial");
            int UserNum = int.Parse(Console.ReadLine());
            FactorialOfNumber(UserNum);

            // Question 8 
            Console.WriteLine("Enter a Number");
            int UserN = int.Parse(Console.ReadLine());
            if (PrimeNumberChecker(UserN) == true)
            {
                Console.WriteLine("User Number is a Prime Number.");
            }
            else
            {
                Console.WriteLine("User Number is Not a Prime Number.");
            }

            // Question 9
            Console.WriteLine("Enter a Number");
            int FirstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Number");
            int SecondSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Number");
            int ThirdSide = int.Parse(Console.ReadLine());
            TypeOfTriangleChecker(FirstSide, SecondSide, ThirdSide);

            // Question 10
            // Using Multiple Print
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            // Using loop
            PatternPrint();
            

            // Bounce Question
            Console.WriteLine("Enter a Number");
            string Numb = Console.ReadLine();
            if (PalidromeNumberChecker(Numb))
            {
                Console.WriteLine("Number Is Palidrome");
            }
            else {
                Console.WriteLine("Number Is NOT Palidrome");
            }
        }

        public static void SumOfTwoInteger(int A, int B)  // Question 1
        {
            int Total = 0;
            Total = A + B;
            Console.WriteLine("Your Sum is {0}", Total + "\n");
        }

        public static void EvenNumberPrinting(int N) // Question 2
        {
            for (int i = 2; i <= N; i = i + 2)

                Console.WriteLine(i);
        }

        public static void LeapYearChecker(int Year) // Question 3
        {
            if (Year % 4 == 0 || Year % 100 == 0 || Year % 400 == 0)
            {
                Console.WriteLine("{0} is Leap Year", Year);
            }
            else
            {
                Console.WriteLine("{0} is Not a Leap Year", Year);
            }
        }

        public static void KmhToMphConversion(int A) // Question 4
        {
            Double ConversionFactor = 0.621371;
            Double Mph = A * ConversionFactor;
            Console.WriteLine("Miles Per Hour = {0} ", Mph);
        }

        public static void BuzzNumberFinder(int N)  // Question 5
        {
            if (N % 7 == 0 || N % 10 == 7)
            {
                Console.WriteLine("Enter Number is a Buzz Numnber");
            }
            else 
            {
                Console.WriteLine("Enter Number is NOT a Buzz Numnber");
            }

        }

        public static void TablePrinting(int N)  // Question 6
        {
            int Multiplication = 0;
            for (int i = 1; i <= 10; i++)
            {
                Multiplication = i * N;
                Console.WriteLine(Multiplication);
            }
        }

        public static void FactorialOfNumber(int N) // Question 7
        {
            int result = 1;
            if (N < 0)
            {
                Console.WriteLine("Your Number is Invalid");
            }
            if (N == 0 || N == 1)
            {
                Console.WriteLine("Factorial of {0} = result");
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    result = result * i; 
                }
            }
            Console.WriteLine("Factorial of {0} = {1}" ,N, result);
        }

        public static bool PrimeNumberChecker(int N) // Question 8
        {
            int A = N / 2;

            if (N <= 1)
            {
                return false;
            }
            for (int i = 2; i <= A; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void TypeOfTriangleChecker(int A, int B, int C) // Question 9
        {
            if (A == B && B == C && C == A)
            {
                Console.WriteLine("Triangle is Equilateral Triangle.");
            }
            else if (A != B && B != C && C != A)
            {
                Console.WriteLine("Triangle is Scalene Triangle.");
            }
            else
            {
                Console.WriteLine("Triangle is Iscoceles Triangle.");
            }
        }

        public static void PatternPrint() // Question 10
        {
            int A = 1;
            while (A <= 5)
            {
                int B = 1;
                while (B <= A)
                {
                    Console.Write("*");
                        B++;
                }
                Console.WriteLine();
                A++;
            }
        }

        public static bool PalidromeNumberChecker(String N)  // Bounce Question 
        {
            int leftside = 0;
            int rightside = N.Length - 1;
            while (leftside < rightside)
            {
                if (N[leftside] != N[rightside])
                {
                    return false;
                }
                leftside++;
                rightside--;
            }
            return true;
        }
    }
}

