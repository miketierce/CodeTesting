using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        static void Main()
        {
            string gamechoice;
            string gameanswer;

            ComputerSpeak();
            Console.WriteLine("What is your name?");

            UserNameFont();
            Console.Write("Guest 45789: ");
            UserSpeakFont();
            string UserName = Console.ReadLine();

            ComputerSpeak();
            Console.Write("Hello ");
            Console.Write(UserName);
            Console.WriteLine(", want to play a game? (y/n)");

            UserNameFont();
            Console.Write(UserName);
            Console.Write(": ");
            UserSpeakFont();
            gameanswer = Console.ReadLine();

            if (gameanswer == "y")
            {
                PrintMenu();

                UserNameFont();
                Console.Write(UserName);
                Console.Write(": ");
                UserSpeakFont();
                gamechoice = Console.ReadLine();

                while (gameanswer == "y")
                {
                    if (gamechoice == "a")
                    {
                        TicTac();

                    }

                    else if (gamechoice == "b")
                    {
                        Snake();

                    }

                    else if (gamechoice == "c")
                    {
                        Nuclear();

                    }

                    else if (gamechoice == "d")
                    {
                        StopPlaying();
                        break;

                    }
                    else if (gamechoice != "a" || gamechoice != "b" || gamechoice != "c")
                    {
                        ComputerSpeak();
                        Console.WriteLine("Choose something I know how to play!");
                    }

                    UserNameFont();
                    Console.Write(UserName);
                    Console.Write(": ");
                    UserSpeakFont();
                    gamechoice = Console.ReadLine();
                }

                UserNameFont();
                Console.Write(UserName);
                Console.Write(": ");
                UserSpeakFont();
                gameanswer = Console.ReadLine();
            }

            else
            {
                ComputerSpeak();
                Console.WriteLine("Maybe another time...");
                //Tell the user to type <enter> to exit using Red text.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nType <Enter> to Exit.");
                Console.ResetColor();//Reset the console color to the default.
                Console.ReadKey();
                
            }


        
        }


        static void ComputerSpeak()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Computer: ");
            Console.ForegroundColor = ConsoleColor.White;
         }
    
        static void UserNameFont()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        static void UserSpeakFont()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintMenu()
        {
            ComputerSpeak();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("|    Which Game?        |");
            Console.WriteLine("|                       |");
            Console.WriteLine("| A: Tic Tac Toe        |");
            Console.WriteLine("| B: Snake              |");
            Console.WriteLine("| C: War                |");
            Console.WriteLine("| D: Quit               |");
            Console.WriteLine("*************************");
        }
    
        static void TicTac()
        {
            ComputerSpeak();
            Console.WriteLine("No way! You are to good at Tic Tac Toe! Let's play something else");
            PrintMenu();
            
        }

        static void Snake()
        {
            ComputerSpeak();
            Console.WriteLine("Shoot! I left the snake in my other tower! Let's play something else");
            PrintMenu();
        }

        static void Nuclear()
        {
            ComputerSpeak();
            Console.WriteLine("WOW! I was just kidding! You need an outlet for that anger! Let's play something else");
            PrintMenu();
        }
        
        static void StopPlaying()
        {
            ComputerSpeak();
            Console.WriteLine("Maybe another time...");
            
            //Tell the user to type <enter> to exit using Red text.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nType <Enter> to Exit.");
            Console.ResetColor();//Reset the console color to the default.

        }
    }
             //   //Tell the user to type <enter> to exit using Red text.
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("\nType <Enter> to Exit.");
            //    Console.ResetColor();//Reset the console color to the default.
             //   Console.ReadKey();

}
