using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choseYourOwnAdenture
{
    class Program
    {
        //The beggining of it all
        static void Main(string[] args)
        {
            Console.WriteLine("This is the start of the text adventure: ");
            Console.WriteLine("Do you want to play this game?. Y/N");
            string option1 = Console.ReadLine();
            if (option1=="Y" || option1=="y")
            {
                option1Yes();
            } else if (option1=="N" || option1 == "n")
            {
                //If user says no, game ends
                option1No();
            } else
            {
                //If user inputs something that isnt a y or n, they have to restart.
                Console.WriteLine("Wrong answer, restart");
            }
            Console.WriteLine("");
            Console.WriteLine("That is the end of the game.");
            Console.ReadKey();
        }



        static void option1Yes()
        {
            Console.WriteLine("It worked!");
            Console.WriteLine("Are you sure? Y/N");
            string option2 = Console.ReadLine();
            //Lots of if else statments in if else statments.
            if (option2 == "Y" || option2 == "y")
            {
                Console.WriteLine("Okay, IDK why you'd wanna play this.");
                Console.WriteLine("Why do you want to play this game? Y/N");
                string option3 = Console.ReadLine();
                if (option3=="Y"|| option3 == "y")
                {
                    Console.WriteLine("That made no sense.");
                    Console.WriteLine("Why did you type a Y to a question that obisouly is not a yes or no question. Y/N");
                    string option4 = Console.ReadLine();
                    if (option4 == "Y" || option4 == "y")
                    {
                        Console.WriteLine("That once again does not make any sense.");
                    }
                    else if (option4=="N"|| option4=="n")
                    {
                        Console.WriteLine("That once again does not make any sense.");
                    }else
                    {
                        Console.WriteLine("Why didnt you type a y or n? I hope you like pain, restart.");
                    }
                } else if (option3 == "N" || option3 == "n")
                {
                    Console.WriteLine("That made no sense.");
                    Console.WriteLine("Why did you type a N to a question that obisouly is not a yes or no question. Y/N");
                    string option4 = Console.ReadLine();
                    if (option4 == "Y" || option4 == "y")
                    {
                        Console.WriteLine("That once again does not make any sense.");
                    }
                    else if (option4 == "N" || option4 == "n")
                    {
                        Console.WriteLine("That once again does not make any sense.");
                    }
                    else
                    {
                        Console.WriteLine("Why didnt you type a y or n? I hope you like pain, restart.");
                    }
                } else
                {
                    Console.WriteLine("Why didnt you type a y or n? I hope you like pain, restart.");
                }

            } else if (option2=="N"|| option2=="n")
            {
                //Again, if user says no, game ends
                option1No();
            }
            else
            {
                Console.WriteLine("Why didnt you type a y or n? I hope you like pain, restart.");
            }
        }
        static void option1No()
        {
            Console.WriteLine("Okay... I dont blame you.");
        }
    }
}
