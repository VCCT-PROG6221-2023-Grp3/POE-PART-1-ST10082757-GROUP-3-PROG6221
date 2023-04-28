using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{
    public class COOKBOOK
    {
        //declarations

        public string[] ingredients;
        public double[] sum;
        public double[] sumAndextra;
        public string[] measure;
        public string[] steps;

        //this method creates or holds the instances of the arrays

        public void SAFE()
        {
            ingredients = new string[0];
            sum = new double[0];
            measure = new string[0];
            steps = new string[0];

        }

        //this method has the functions that ask the user to enter the input
        public void OUTPUT_RECIPE()
        {
            //Ask user to enter the ingredients

            Console.Write("Number of Ingredients: \n");
            int Ingredients = 0; //Ingredients local variable. convert string to int 

            //ensures the user enters an int and nothing else
            try
            {
                Ingredients = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("INVALID! INT ONLY\n");
                OUTPUT_RECIPE();
            }
            //instances to store the results of the above input of ingredients in these arrays

            ingredients = new string[Ingredients];
            sum = new double[Ingredients];
            measure  = new string[Ingredients];

            // reapeat this block of code as many times as instructed by user input

            for(int i = 0; i < Ingredients; i++) 
            { 
            Console.WriteLine($"Details for ingredient number {i + 1}: \n"); // the dollar sign provides a more convenient syntax to format strings

                Console.Write("Ingredient name: \n");
                ingredients[i] = Console.ReadLine();

                Console.Write("\nQuantity: \n");
                sum[i] = double.Parse(Console.ReadLine());

                Console.Write("\nUnit (grams {g}, etc): \n");
                measure[i] = Console.ReadLine();
            }

            //storing user input in order to scale for later
            sumAndextra = new double[Ingredients];
            Array.Copy(sum, sumAndextra, Ingredients);
           
            //local variable to use in exception 
            int stepsNo = 0;

            while(stepsNo == 0)
            {
                try
                {
                    //gets input from the user on how many steps the user wants
                    Console.Write("\nHow many steps does this need?: \n");
                     stepsNo = int.Parse(Console.ReadLine());

                    //instance of the stepsNo to be stored in array
                    steps = new string[stepsNo];

                    //displays number of steps according to how many steps are inputted
                    for (int i = 0; i < stepsNo; i++)
                    {
                        Console.Write($"\nStep number {i + 1}: \n");
                        steps[i] = Console.ReadLine();
                    }
                }

                //displaying error message
                catch (Exception e) 
                { 
                    Console.WriteLine("INVALID! INT ONLY\n"); 
                }
            }
            
        }
        //------------------------------------------------------------------------END-----------------------------------------------------------------------------------------

        public void SCALE()
        {
            // Asks the user to select which scaling method they prefer
            Console.WriteLine("Enter 1 of the scaling factors using a comma; 0,5 or 2 or 3 \n");
            double scale = 0;

            try
            {
                //setting the input to double
                scale = double.Parse(Console.ReadLine());

                //if the scaling input is not anyone of these then the error message will display
                if (scale != 0.5 && scale != 2 && scale != 3)
                {
                    Console.WriteLine("INVALID!\n");
                    SCALE();
                    return;
                }

                //calculates the scaling by multiplying the quantity to the scale and making it the new sum
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = sumAndextra[i] * scale;
                }
            }
            //displays error and takes us back to the beginning of this method
            catch (Exception e)
            {
                Console.WriteLine("INVALID!\n");
                SCALE();
            }
            //displays once successful
            Console.WriteLine($"SCALING COMPLETE, choose option 2 to confirm\n");
        }
        //------------------------------------------------------------------------END-----------------------------------------------------------------------------------------

        public void DISPLAY()
            {
            // displays the ingredients inputted by the user

            
            Console.WriteLine("Ingredients: \n");  
            
            for(int i = 0; i < ingredients.Length; i++)
            {
                //compilation of quantity + measurement of ingredient + the ingredient name 
                Console.WriteLine($"==========={sum[i]} {measure[i]} of {ingredients[i]}=============\n");
            }

            //displays all the steps the user inputted 

            Console.WriteLine("Steps\n");
            for(int i = 0;i < steps.Length;i++)
            {
                Console.WriteLine($"=========== {steps[i]} ===========\n");
            }
        }


        //------------------------------------------------------------------------END-----------------------------------------------------------------------------------------

        public void RESET()
        {
            //resets the quantities to their origional values before scaling

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] /= 2;
            }

            Console.WriteLine($"RESET COMPLETE, choose option 2 to confirm\n");

        }
        //------------------------------------------------------------------------END-----------------------------------------------------------------------------------------

        public void DELETE()
        {
            //resetting array values back to default once selecting option 4

            ingredients = new string[0];
            sum = new double[0];
            measure = new string[0];
            steps = new string[0];


            Console.WriteLine($"DELETE COMPLETE, choose option 2 to confirm\n");

        }


    }
}
        //------------------------------------------------------------------------END-----------------------------------------------------------------------------------------
