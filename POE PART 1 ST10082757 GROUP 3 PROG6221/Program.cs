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
            //calling the class with the functions
            COOKBOOK recipe = new COOKBOOK();

            //while loop to display the statements and execute their action in the switch statements
            while (true) 
            {
                Console.WriteLine("1: ENTER RECIPE DETAILS");
                Console.WriteLine("2: DISPLAY DETAILS");
                Console.WriteLine("1: SCALE RECIPE");
                Console.WriteLine("1: RESET AMOUNT");
                Console.WriteLine("1: DELETE RECIPE ENTRY");
                Console.WriteLine("1: EXIT");

                //input is read and then refered to one of these cases
                string chose = Console.ReadLine();

                switch(choose)
                {
                    //case statements of choices above
                    case "1":
                        recipe.DETAILS();
                        break;

                    case "2":
                        recipe.OUTPUT_RECIPE();
                        break;

                        case "3":
                        Console.Write("Enter your prefered scaling factor 0.5 (half), 2 (double) or 3 (triple): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.SCALE(factor);
                        break;

                        case "4":
                        recipe.RESET();
                        break;

                        case "5":
                        recipe.DELETE();
                        break;

                        case"6":
                        Console.WriteLine("LEAVING BYE!!");
                        return;

                    default:
                        Console.WriteLine("INVALID OPTION!");
                        break;
                }
            }
        }
    }
}
