using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1_1
            //int a;
            //int b;
            //string strDigit;

            //try
            //{
            //    Console.Write("Enter digit a: ");
            //    strDigit = Console.ReadLine();
            //    a = Int32.Parse(strDigit);

            //    Console.Write("\nEnter digit b: ");
            //    strDigit = Console.ReadLine();
            //    b = Int32.Parse(strDigit);

            //    Console.WriteLine($"\na + b = {a + b} \na - b = {a - b} \na * b = {a * b} \na / b = {a * 1.0 / b}");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //Console.Write("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task1_2
            //string name;

            //Console.WriteLine("How are you?");
            //Console.Write("Name: ");
            //name = Console.ReadLine();

            //Console.Write("\nYou are {0}", name);

            //Console.Write("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task1_3
            //string strChar;
            //char firstChar;
            //char secondChar;
            //char thirdChar;

            //Console.Write("\nEnter first char: ");
            //strChar = Console.ReadLine();
            //firstChar = Convert.ToChar(strChar);

            //Console.Write("\nEnter second char: ");
            //strChar = Console.ReadLine();
            //secondChar = Convert.ToChar(strChar);

            //Console.Write("\nEnter third char: ");
            //strChar = Console.ReadLine();
            //thirdChar = Convert.ToChar(strChar);

            //Console.WriteLine($"\nYour enter chars: \"{firstChar}\", \"{secondChar}\", \"{thirdChar}\"");

            //Console.Write("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task1_4
            //int firstDigit;
            //int secondDigit;
            //string strDigit;
            //string result = "";

            //try
            //{
            //    Console.Write("Enter first digit: ");
            //    strDigit = Console.ReadLine();
            //    firstDigit = Int32.Parse(strDigit);

            //    Console.Write("Enter second digit: ");
            //    strDigit = Console.ReadLine();
            //    secondDigit = Int32.Parse(strDigit);

            //    result = CheckDigits(firstDigit, secondDigit);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //if (result != "")
            //{
            //    Console.WriteLine(result);
            //}

            //Console.ReadKey();
            #endregion

            #region HomeWork1_B
            //float squareSide;
            //float squareArea;
            //float squarePerimetr;
            //string strSquareSide;

            //try
            //{
            //    Console.Write("Enter square side: ");
            //    strSquareSide = Console.ReadLine();
            //    squareSide = float.Parse(strSquareSide);
            //    squareArea = squareSide * squareSide;
            //    squarePerimetr = 4 * squareSide;
            //    Console.WriteLine($"Square Area = {squareArea} \nSquare Perimetr = {squarePerimetr} ");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");

            //Console.ReadKey();
            #endregion

            #region HomeWork1_C
            int age;
            string strAge;
            string name;

            Console.WriteLine("What is your name?");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nHow old are you, {0}?");
            Console.Write("Age: ");
            strAge = Console.ReadLine();
            bool isDigit = Int32.TryParse(strAge, out age);

            Console.Clear();

            if (isDigit)
            {
                Console.WriteLine($"Name: {name} \nAge: {age}");
            }
            else
            {
                Console.WriteLine($"Name: {name} you enter wrong age \"{strAge}\"");
            }

            Console.WriteLine("\nPress any key...");

            Console.ReadKey();
            #endregion

            #region HomeWork1_D
            //double radius;
            //double circleLength;
            //double circleArea;
            //double circleVolume;
            //string strRadius;

            //Console.Write("Enter radius: ");
            //try
            //{
            //    strRadius = Console.ReadLine();
            //    radius = double.Parse(strRadius);

            //    circleLength = 2 * Math.PI * radius;
            //    circleArea = Math.PI * radius * radius;
            //    circleVolume = Math.PI * radius * radius * radius;

            //    Console.Clear();
            //    Console.WriteLine($"Circle Length: {circleLength} \nCircle Area: {circleArea} \nCircle Volume: {circleVolume}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion
        }

        #region Methods
        public static string CheckDigits(int fistDigit, int secondDigit)
        {
            if (fistDigit >= 0 && secondDigit >= 0)
            {
                return $"Both digit are positive: {fistDigit}, {secondDigit}";
            }
            else if (fistDigit >= 0 && secondDigit < 0)
            {
                return $"Only first digit is poitive: {fistDigit}, {secondDigit}";
            }
            else if (fistDigit < 0 && secondDigit >= 0)
            {
                return $"Only second digit is poitive {fistDigit}, {secondDigit}";
            }
            else
            {
                return $"Both digit are negative {fistDigit}, {secondDigit}";
            }
        }
        #endregion
    }
}
