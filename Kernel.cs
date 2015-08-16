using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        public static bool hasRun = false;
        public static string username = "";

        public string getArgs(string str, int index)
        {

            return str.Split(' ')[index];


        }

        public int getIntArgs(string str, int index)
        {

            return Int32.Parse(str.Split(' ')[index]);


        }

        protected override void BeforeRun()
        {
            Console.WriteLine(@"              ___.-~ ~-._   __....__");
            Console.WriteLine(@"            .'         \ ~ ~          -.");
            Console.WriteLine(@"           /  _      )   \               \");
            Console.WriteLine(@"          /   a)    /     |                \");
            Console.WriteLine(@"         :         /      |                 \");
            Console.WriteLine(@"    < -._|   .-.  (      /   .             ;\\");
            Console.WriteLine(@"      -.  --'_.'-.;\___/'   .      .       | \\");
            Console.WriteLine(@"  _     /:--      |        /     /        .'  \\");
            Console.WriteLine(@" ( \   / /        |       '     '         /    : ;");
            Console.WriteLine(@"  \'\_/ /         .\     / ~ =-.:        /       ");
            Console.WriteLine(@"    ._.'          / \    |       \      /(");
            Console.WriteLine(@"                 /  /\   |         Y   /  \");
            Console.WriteLine(@"                J  /  Y  |         |  / \  \");
            Console.WriteLine(@"               /  |   |  |         |  |  |  |");
            Console.WriteLine(@"               ---   /___|        /___|  /__|");


            Console.WriteLine(@" ___   _                _                    _        ___    ___ ");
            Console.WriteLine(@"| __| | |  ___   _ __  | |_    __ _   _ _   | |_     / _ \  / __|");
            Console.WriteLine(@"| _|  | | / -_) | '_ \ | ' \  / _  | | ' \  |  _|   | (_) | \__ \");
            Console.WriteLine(@"|___| |_| \___| | .__/ |_||_| \__,_| |_||_|  \__|    \___/  |___/");
            Console.WriteLine(@"                |_|                                              ");

        }

        protected override void Run()
        {

            if (!hasRun)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                hasRun = true;
            }


            Console.Write(username + " $ ");
            var input = Console.ReadLine();



            if (getArgs(input, 0) == "test") //new command
            {
                Console.WriteLine("peen");

            }
            else if (getArgs(input, 0) == "echo")
            {
                Console.WriteLine(getArgs(input, 1));
            }
            else if (getArgs(input, 0) == "calc")
            {
                int num1 = getIntArgs(input, 1);
                int num2 = getIntArgs(input, 3);
                string op = getArgs(input, 2);
                if (getArgs(input, 1) == "help")
                {
                    Console.WriteLine("operators: + | - | * | / |");
                }
                else
                {

                    if (op == "+")
                    {
                        Console.WriteLine(num1 + num2);
                    }
                    else if (op == "-")
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else if (op == "*")
                    {
                        Console.WriteLine(num1 * num2);
                    }
                    else if (op == "/")
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Put spaces between your operands. (calc 1 + 1)");
                    }
                }
            }



            else if (input == "help")
            {
                Console.WriteLine("===========================[Help Pages]===========================");
                Console.WriteLine("|                     Elephant OS help pages                     |");
                Console.WriteLine("|              Created by Josh Siegel and Evan Jewell            |");
                Console.WriteLine("|              Contributor         Barek Bentley                 |");
                Console.WriteLine("|              Written in C# using Cosmos framework              |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|test - Simple I/O test                                          |");
                Console.WriteLine("|echo <text> - Echoes given text back. Working example of passing|");
                Console.WriteLine("|arguments to a method.                                          |");
                Console.WriteLine("|help - Displays this screen                                     |");
                Console.WriteLine("|halt - Shut down Elephant OS                                    |");
                Console.WriteLine("|version - Version and license information                       |");
                Console.WriteLine("|calc - Simple calculator. Syntax example: (calc 1 + 1) Type calc|");
                Console.WriteLine("|help for more info                                              |");
                Console.WriteLine("|trunk - EXTREMELY basic text editor                             |");
                Console.WriteLine("|clear- Clear the console                                        |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|(c) Elephant OS Project                                         |");
                Console.WriteLine("|================================================================|");




            }
            else if (input == "halt" || input == "shutdown")
            {
                Console.WriteLine("lel you can't shut me off. Might actually work in a future version");

            }
            else if (input == "version")
            {
                var version = "v1.0";
                Console.WriteLine("Elephant OS " + version);
                Console.WriteLine("This operating system is open source and free to use and modify.");


            }
            else if (input == "ie")
            {
                Console.WriteLine("EW Internet Explorer");
                Console.WriteLine("Even an operating system this terrible knows not to use IE.");

            }
            else if (getArgs(input, 0) == "trunk")
            {
                Console.WriteLine("=============================[Trunk]==============================");
                Console.WriteLine("|" + getArgs(input, 1) + "                                       |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|================================================================|");

            }
            else if (input == "clear")
            {

                Console.Clear();

            }
            else if (input == "ejokes")
            {
                int k = 0;
                if (k > 3)
                {
                    k = 0;
                }
                string[] jokes = { "Why do elephants wear shoes with yellow soles? So you don't see them when they float upside down in a bowl of mustard.", "What game do four elephants in a car play? Squash.", "Why are elephants wrinkled? t llWell have you ever tried to iron one?" };

                Console.WriteLine(jokes[k]);
                k++;

            }
            else if (input == "github")
            {
                Console.WriteLine("github.com/stevethedude/elephantOS");

            }
            else
            {
                Console.WriteLine("Unknown command. Type help for help.");
            }

        }

    }

}
