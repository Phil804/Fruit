using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.Red;
            ForegroundColor = ConsoleColor.Green;
            Clear();

            Fruit Apple = new Fruit();
            Fruit Grapes = new Fruit();

            Apple.FoodID = 1;
            Apple.Name = "Apple";
            Apple.Description = "Red apple";
            Apple.Cost = 1.48;

            Grapes.FoodID = 2;
            Grapes.Name = "Grapes";
            Grapes.Description = "Seedless grapes";
            Grapes.Cost = 5.08;

            WriteLine("{0,5}{1,10}{2,20}{3,20}", "Food ID", " Name", " Description", " Cost");
            WriteLine("{0,5}{1,10}{2,20}{3,20}", Apple.FoodID, Apple.Name, Apple.Description, Apple.Cost.ToString("C"));
            WriteLine("{0,5}{1,10}{2,20}{3,20}", Grapes.FoodID, Grapes.Name, Grapes.Description, Grapes.Cost.ToString("C"));

            ReadKey();

        }
    }
}
