using System;
using System.ComponentModel;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out var num);
            //Console.WriteLine($"You entered: {num}");
            #endregion

            #region Q2
            //string text = "b^<>bbb";
            //int num = int.Parse(text); // Will cause an Exception --> menf3sh ahwl mn string - int <--
            #endregion

            #region Q3
            //float a = 7.5f;
            //float b = 2.1f;
            //float c = a + b;
            //Console.WriteLine(c); // 9.6 ==works fine
            #endregion

            #region Q4
            ////Write C# program that Extract a substring from a given string.
            //string Text = "Playing";
            //string substring = Text.Substring(0,4);
            //Console.WriteLine(substring);
            #endregion

            #region Q5
            ///*Write C# program that Assigning one value type variable to another 
            //  and modifying the value of one variable and mention what will happen*/

            //int x = 5;
            //int y = 9;
            //x = y;
            //Console.WriteLine(x); // 9
            //x = 11;
            //Console.WriteLine(x); //11
            //Console.WriteLine(y);
            #endregion

            #region Q6
            ///*Write C# program that Assigning one reference type
            //variable to another and modifying the object through
            //one variable and mention what will happen*/

            //Point point1 = new Point();
            //point1.x = 10;
            //point1.y = 20;
            //Console.WriteLine(point1.x); //10
            //Console.WriteLine(point1.y); //20

            //Point point2 = point1;
            //Console.WriteLine(point2.x); //10
            //Console.WriteLine(point2.y); //20

            //point2.x = 30;
            //point2.y = 50;
            //Console.WriteLine(point2.x); //30
            //Console.WriteLine(point2.y); //50

            //Console.WriteLine(point1.x); //10
            //Console.WriteLine(point1.y); //20
            //// lw 8errt fe data p2 -- data p1 htt8er 3shan al atnen ba'a lehom nafs al reference 
            #endregion

            #region Q7
            ////Write C# program that take two string variables and print them as one variable 
            //string txt1 = "hhh";
            //string txt2 = "bbb";
            //Console.WriteLine($"{txt1}{txt2}");
            #endregion

            #region Q8
            ///*Write a program that calculates the simple interest
            //given the principal amount, rate of interest,
            //and time. The formula for simple interest is 
            //Interest = (principal * rate * time ) /100.*/
            //Console.WriteLine("Please Enter the principal amount: ");
            //float.TryParse(Console.ReadLine(), out var principal);
            //Console.WriteLine("Please Enter the rate of interest: ");
            //float.TryParse(Console.ReadLine(), out var rate);
            //Console.WriteLine("Please Enter the time: ");
            //float.TryParse(Console.ReadLine(), out var time);

            //float Interest = (principal * rate * time) / 100;
            //Console.WriteLine($"The Interest is: {Interest}");
            #endregion

            #region Q9
            ///*Write a program that calculates the Body Mass Index 
            //(BMI) given a person's weight in kilograms and height
            //in meters. The formula for BMI is
            //BMI = (Weight)/(Height*Height)*/

            //Console.WriteLine("Please Enter Your weight in Kgm: ");
            //float.TryParse(Console.ReadLine(), out var weight);
            //Console.WriteLine("Please Enter Your height in meters: ");
            //float.TryParse(Console.ReadLine(), out var height);

            //float BMI = (weight)/(height * height);
            //Console.WriteLine($"The Interest is: {BMI}");
            #endregion

            #region Q10
            /*Write a program that uses the ternary operator to
            check if the temperature is too hot, too cold, or
            just good. Assign the result in a variable then
            display the result. Assume that below 10 degrees is
            "Just Cold", above 30 degrees is "Just Hot", and
            anything else is "Just Good".*/

            //Console.WriteLine("Please enter the temperature: ");
            //float.TryParse(Console.ReadLine(), out var temperature);
            //if (temperature > 30)
            //{
            //    Console.WriteLine("Just Hot");
            //}
            //else if (temperature < 10)
            //{
            //    Console.WriteLine("Just Cold");
            //}
            //else
            //{
            //    Console.WriteLine("Just Good");
            //}
            #endregion

            #region Q11
            /*Write a program that takes the date from the user
            and displays it in various formats using string interpolation.
            Ex :
            Today’s date : 20 , 11 , 2001
            Today's date : 20 / 11 / 2001
            Today's date : 20 – 11 – 2001*/

            //Console.WriteLine("Enter the day: ");
            //int.TryParse(Console.ReadLine(), out var day);
            //Console.WriteLine("Enter the month: ");
            //int.TryParse(Console.ReadLine(), out var month);
            //Console.WriteLine("Enter the year: ");
            //int.TryParse(Console.ReadLine(), out var year);
            //Console.Clear();

            //Console.WriteLine("Choose formate 1,2 or 3: ");
            //int.TryParse(Console.ReadLine(), out var Format);
            //Console.Clear();

            //switch (Format)
            //{
            //    case 1:
            //        Console.WriteLine($"Today’s date: {day} , {month} , {year}");
            //        break;

            //    case 2:
            //        Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Today's date: {day} – {month} – {year}");
            //        break;
            //}

            #endregion

            #region Q12
            //What is the output of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            // C)  The event is on 06/14/2024

            #endregion

            #region Q13
            //Which of the following statements is correct
            //about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            // f) A value 1 will be assigned to d.
            #endregion

            #region Q14
            //Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //D) 6 1
            #endregion

            #region Q15
            //What will be the output of the C# code given below?
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            // D)7 7
            #endregion
        }
    }
}
