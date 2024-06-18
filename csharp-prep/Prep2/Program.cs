using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage?");
        string userGrade = Console.ReadLine();

        string letter; 

        int percent = int.Parse(userGrade);    

        if (percent > 90 || percent == 90)
        {
            letter = ("A");
        }

        else if ((percent > 80 || percent == 80) && percent<90)
        {
            letter = ("B");
        }

        else if ((percent > 70 || percent == 70) && percent<80)
        {
            letter = ("C");
        }

        else if ((percent > 60 || percent == 60) && percent<70)
        {
            letter = ("D");
        }

        else
        {
            letter = ("F");
        }

        Console.WriteLine($"This is your grade: {letter}");

        if (percent>70 || percent==70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }

        else
        {
            Console.WriteLine ("Sorry, better luck next time!");
        }
    }


}