using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{
    public class Program
    {
        #region
        public List<COOKBOOK> cookies = new List<COOKBOOK>();
        public List<recipe> recipes = new List<recipe>();
        public List<ingredients> ingred = new List<ingredients>();
        #endregion
        static void Main(string[] args) 
        {

            COOKBOOK cookies = new COOKBOOK();
            //while loop to display the statements and execute their action in the switch statements
            while (true)
            {
                Console.WriteLine("======================================================================================================================\n");
                Console.WriteLine("\t\t\t\t\t\tWELCOME TO THE RECIPE MANAGING APPLICATION ");
                Console.WriteLine("======================================================================================================================\n");
                 

                //while loop to display the statements and execute their action in the switch statements
                while (true)
                {
                    Console.WriteLine("\nPLEASE CHOOSE AN OPTION FROM THE FOLLOWING:\n");

                    Console.WriteLine("1: ENTER RECIPES DETAILS\n");

                    Console.WriteLine("2: VIEW LIST OF RECIPES\n");

                    Console.WriteLine("3: SCALE INGREDIENT\n");

                    Console.WriteLine("5: RESET AMOUNT\n");

                    Console.WriteLine("6: DELETE RECIPE ENTRY\n");

                    Console.WriteLine("7: EXIT\n");


                    //input is read and then refered to one of these cases
                    string choose = Console.ReadLine();

                    switch (choose)
                    {
                        //options of choices above
                        case "1":
                            cookies.ADDINGRECIPE();
                            break;

                        case "2":
                            cookies.VIEWRECIPE();
                            break;

                        case "3":
                            cookies.SCALE();
                            break
                                ;
                        case "5":
                            cookies.RESET();
                            break;

                        case "6":
                            cookies.DELETE();
                            break;

                        case "7":
                            Console.WriteLine("LEAVING. THANK YOU!!");
                            return;

                        default:
                            Console.WriteLine("INVALID OPTION! PLEASE START WITH OPTION 1");
                            break;
                    }
                }
            }
        }
    }
}
