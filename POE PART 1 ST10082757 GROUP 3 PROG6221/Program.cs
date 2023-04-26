using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //calling class with  functions
                COOKBOOK recipes = new COOKBOOK();

                Console.WriteLine("================================================================================================================\n");
                Console.WriteLine("\t\tWELCOME ");
                Console.WriteLine("================================================================================================================\n");


                //while loop to display the statements and execute their action in the switch statements
                while (true)
                {
                    Console.WriteLine("1: ENTER RECIPE DETAILS\n");

                    Console.WriteLine("2: DISPLAY DETAILS\n");

                    Console.WriteLine("3: SCALE RECIPE\n");

                    Console.WriteLine("4: RESET AMOUNT\n");

                    Console.WriteLine("5: DELETE RECIPE ENTRY\n");

                    Console.WriteLine("6: EXIT");

                    //input is read and then refered to one of these cases
                    string choose = Console.ReadLine();

                    switch (choose)
                    {
                        //options of choices above
                        case "1":
                            recipes.OUTPUT_RECIPE();
                            break;

                        case "2":
                            recipes.DISPLAY();
                            break;

                        case "3":
                            recipes.SCALE();
                            break;

                        case "4":
                            recipes.RESET();
                            break;

                        case "5":
                            recipes.DELETE();
                            break;

                        case "6":
                            Console.WriteLine("LEAVING. THANK YOU!!");
                            return;

                        default:
                            Console.WriteLine("INVALID OPTION!");
                            break;
                    }
                }
            }
        }
}
