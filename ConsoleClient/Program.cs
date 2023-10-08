/**
	 * Class Name:	Program.cs
	 * Purpose:	The purpose of this main class is to call all classes to run the program	
	 * Coder: Agnita Paul		
	 * Date: 13 may, 2022			
*/


using DocumentBuilderLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Director.PrintUsage();
            Console.WriteLine();
            Director director=null;

           string input="";

            do 
            {
                //read input if user print blank space
                do
                {
                    Console.Write("> ");
                    input = Console.ReadLine()!.ToLower();
                    if (input == "")
                    {
                        Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                    }

                } while (input == "");

                if (input == "help") { Director.PrintUsage(); }
                else if (input =="print")
                {
                    //check if director is null
                    if (director is null)
                    {
                        Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                        break;
                    }

                    //print output
                    director.Print();
                    Console.WriteLine();
                }
                else if (input == "exit")
                {
                    //exit program
                    System.Environment.Exit(1);
                }
                else if (input == "close")
                {
                    //check if director is null
                    if (director is null)
                    {
                        Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                        break;
                    }
                    director.CloseBranch();

                }
                else if (input.Substring(0, 4) == "mode")
                {
                    string checkMode = input;

                        int index = checkMode.IndexOf(':');
                        if (checkMode.Substring(index + 1) == "xml")
                        {
                            director = new Director("xml");
                           // Console.WriteLine("xml\n");
                        }
                        else if (checkMode.Substring(index + 1) == "json")
                        {
                            director = new Director("json");
                           // Console.WriteLine("json\n");
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. For Usage, type 'Help' \n");

                        }
                    

                }
                else if (input.Substring(0, 4) == "leaf")
                {
                    //check if director is null
                    if (director is null)
                    {
                        Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                        break;
                    }
                    //validation check
                    if ((input.IndexOf(':')+ input.IndexOf(':', 4))<1)
                    {
                        Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                        break;
                    }

                    int index = input.IndexOf(':');
                    int index2 = input.LastIndexOf(':');
                    //pass the input to director via _type and _value
                    director._type = input.Substring(index + 1, index2-index-1);
                    director._value= input.Substring(index2 + 1);
                    director.BuildLeaf();

                  //  Console.WriteLine("leaf\n");
                }
                else if (input.Substring(0, 6) == "branch")
                {
                    if (director is null)
                    {
                        Console.WriteLine("Error. Mode has not been set. For usage, type 'Help'");
                        break;
                    }
                    if (input.IndexOf(':') == -1 )
                    {
                        Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                        break;
                    }
                    //pass the input to director via _type
                    int index = input.IndexOf(':');
                        director._type= input.Substring(index + 1);
                        director.BuildBranch();
                }

                else
                {
                    //invalid input
                    Console.WriteLine("Invalid input. For Usage, type 'Help' \n");
                }

            } while (input != "exit");


        }

   
    }


}