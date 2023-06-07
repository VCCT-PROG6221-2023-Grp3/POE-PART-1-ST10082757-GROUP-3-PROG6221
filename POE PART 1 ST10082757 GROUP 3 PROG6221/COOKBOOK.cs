using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{
    //delegate for notification of calories exceeding 300
    public delegate void RecipeCaloriesExceededHandler(string Name, int totalCalories);

    public class COOKBOOK
    {
        //variables and lists needed for this class
        private string RecipeName;
        private double total;
        public string steps { get; set; }
        public List<recipe> recipe01 = new List<recipe>();
        public List<ingredients> ingredientsList = new List<ingredients>();
        List<COOKBOOK> recipeList = new List<COOKBOOK>();
        public List<string> stpList = new List<string>();
        public List<ingredients> ingredients { get; set; }
        public event RecipeCaloriesExceededHandler CaloriesExceeded;


        ingredients ingredients1 = new ingredients();
        recipe recipe1 = new recipe();
        int Ingredients01; 
        double scale;

        //constructor
        public COOKBOOK()
        {
            ingredients = new List<ingredients>();
            stpList = new List<string>();
        }

        //getter and setter for variable used in class
        public string RecipeName1 { get => RecipeName; set => RecipeName = value; }


        #region for deleting
        public void DELETE()
        {
            //names of lists storing data with .clear to delete the information in the lists when the user asks
            recipe01.Clear();
            ingredientsList.Clear();
            recipeList.Clear();
            stpList.Clear();
            ingredients.Clear();

            //message to display upon completion
            Console.WriteLine($"\nDELETE COMPLETE, choose option 2 to confirm\n");
        }
        #endregion

        #region for scaling
        public void SCALE()
        {
            //prompt for user to enter one of the three
            Console.WriteLine("\nEnter 1 of the scaling factors using a comma; 0,5 or 2 or 3 \n"); 

            //setting the input to double
            scale = double.Parse(Console.ReadLine());

            if (scale != 0.5 && scale != 2 && scale != 3)

            {
                //prompt user once they enter invalid information
                Console.WriteLine("\nINVALID!\n");
                SCALE();
                return;
            }
            else
            {
                //calculates the quantity and the choses scale value
                for (int i = 0; i < ingredientsList.Count; i++)
                {

                    ingredientsList[i].Sum *= scale;
                }

            }
            //prompt user upon completion
            Console.WriteLine($"\nSCALING COMPLETE, choose option 2 to confirm\n");


        }

        #endregion

        #region for resetting
        public void RESET() 
        {
            //for loop that divides the quantity by the scale option when the user selects this option
            for (int i = 0; i < ingredientsList.Count; i++)
            {

                ingredientsList[i].Sum /= scale;
            }
        }
        #endregion

        #region for adding recipe
        public void ADDINGRECIPE()
        {
            //lists for storing steps 
            List<string> list = new List<string>();

            string Nameofing = "";

            //prompts 
            Console.WriteLine("\nName of recipe: ");
            string recipeName = Console.ReadLine();

            try
            { 

                Console.WriteLine("\nNumber of Ingredients: ");
                Ingredients01 = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < Ingredients01; i++)
                {
                    Console.WriteLine("\nIngredient name: ");
                    Nameofing = Console.ReadLine();

                    Console.WriteLine("\nQuantity: ");
                    double quantity = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nUnit (grams {g}, etc): ");
                    string unit = Console.ReadLine();

                    Console.WriteLine("\nNumber of calories: ");
                    int cal = int.Parse(Console.ReadLine());
                     
                    //warns user that they have exceeded 300 calories
                    if (cal > 300)
                    {
                        CaloriesExceeded?.Invoke(recipeName, cal);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning: The total calories of recipe " + recipeName + " exceed 300!");
                        Console.ResetColor();
                    }
                     
                    Console.WriteLine("\nName of food group: ");
                    string foodGroup = Console.ReadLine();

                    //values to be stored in ingredients list
                    ingredientsList.Add(new ingredients()
                    {
                        Nameofingredient = Nameofing,
                        Sum = quantity,
                        Measure = unit,
                        Calories = cal,
                        Foodgroup = foodGroup
                    });
                }
            }
            //exception to catch invalid input and promt an error message to the user
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ADDINGRECIPE();
            }


            Console.WriteLine("\nHow many steps does this need?: ");
            int localsteps = int.Parse(Console.ReadLine());

            string steps = "";

            for (int i = 0; i < localsteps; i++)
            {
                Console.WriteLine($"\nSTEPS{i + 1}: ");
                steps = Console.ReadLine();
                list.Add(steps);
            }
            //stores steps into steplist
            stpList = list;

            //stores in recipe list
            recipeList.Add(new COOKBOOK() { RecipeName1 = recipeName, ingredients = ingredientsList, stpList = list });

        }
        #endregion

        #region for viewing recipe
        public void VIEWRECIPE() 
        {
             
            string recipeName = "";

            //displays all the recipe names that were inputted by the user so the recipe knows which one to choose from
            foreach (COOKBOOK ig in recipeList)
            {
                Console.WriteLine($"\nRECIPES: \n{ig.RecipeName1}");
            }

            //prompts user
            Console.WriteLine("\nWhich recipe details would you like to view?: ");
            recipeName = Console.ReadLine();
            try
            {
                //looks for the first value that is exactly like the one inputted and stored in recipeName
                COOKBOOK LookForRecipe = recipeList.FirstOrDefault(x => x.RecipeName1 == recipeName);

                //used to display all the recipe information stored 
                if (LookForRecipe != null)
                {
                    total = 0;
                    foreach (ingredients ig in LookForRecipe.ingredients)
                    {
                        Console.WriteLine($"\nINGREDIENT INFORMATION(S):\n ===NAME OF INGREDIENT: {ig.Nameofingredient}\n ===NUMBER OF INGREDIENT(S): " +
                               $"{ig.Numofingred}\n ===QUANTITY: {ig.Sum}\n ===UNIT OF MEASURE: {ig.Measure}\n ====CALORIES: " +
                               $"{ig.Calories}\n ===FOODGROUP: {ig.Foodgroup}");
                        total = total + ig.Calories;
                        Console.WriteLine();
                         
                    }
                    //displays all the steps inputted
                    TOTCAL(total);
                    foreach (string step in stpList)
                    {
                        Console.WriteLine($"\n ===STEPS: {step}");
                    }
                }                
                //notifes the user that they have entered a wrong recipe 

                else
                {
                    Console.WriteLine("Recipe not found");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        #endregion

        #region for calculating total calories
        public void TOTCAL(double calories)  
        {
            double totalCalories = calories;

            //calcultes and displays everything calorie related
            Console.WriteLine("Total Calories: " + totalCalories);

            if (totalCalories > 300)
            {
                Console.WriteLine("This recipe exceeds 300 calories!");
            }
        }

        #endregion
    }
}




