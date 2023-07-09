using POE_PART_2_ST10082757_GROUP_3_PROG6221;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace POE_PART_2_ST10082757_GROUP_3_PROG6221
{
    //delegate for notification of calories exceeding 300
    public delegate void RecipeNotificationHandler(string message);
    public class COOKBOOK 
    { 

        //variables and lists needed for this class
        private string RecipeName;
        private double total;
        public string steps { get; set; } 
        public List<recipe> recipe01 = new List<recipe>();
        public static List<ingredients> ingredientsList = new List<ingredients>();
        public static List<COOKBOOK> recipeList = new List<COOKBOOK>();
        public List<string> stpList = new List<string>();
        public List<ingredients> ingredients { get; set; }

        public event RecipeNotificationHandler RecipeNotification;

        //calling classes with details that make a recipe
        ingredients ing = new ingredients();
        recipe recipe1 = new recipe();
        int Ingredients01 = 0; 
        double scale = 0; 


        //constructor
        public COOKBOOK()
        {
            //ingredients = new List<ingredients>();
            stpList = new List<string>();
        }

        //getter and setter for variable used in class
        public string RecipeName1 { get => RecipeName; set => RecipeName = value; }

        #region for deleting
        public void DELETE()
        {
            try
            {
                //names of lists storing data with .clear to delete the information in the lists when the user asks
                recipe01.Clear();
                ingredientsList.Clear();
                recipeList.Clear();
                stpList.Clear();
                //ingredients.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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
            
            while (true)
            {
                Console.Write("\nName of Recipe (or 'quit' to exit):\n");
                string recipeName = Console.ReadLine();

                if (recipeName.ToLower() == "quit")
                    break;

                try
                {
                    //prompts 
                    Console.WriteLine("\nNumber of Ingredients: ");
                    Ingredients01 = Convert.ToInt32(Console.ReadLine())
;
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
                            RecipeNotification?.Invoke(Nameofing);

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning: The total calories of recipe " + recipeName + " exceed 300!");
                            Console.ResetColor();
                        }

                        select();
                        stepping();

                        ing.Nameofingredient = Nameofing;
                        ing.Sum = quantity;
                        ing.Measure = unit;
                        ing.Calories = cal;

                        ingredientsList.Add(ing);

                       
                    }
                    recipeList.Add(new COOKBOOK() { RecipeName1 = recipeName, ingredients = ingredientsList, stpList = list });


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
 
        }
        #endregion

        #region steps
        public void stepping()
        {
            List<string> list = new List<string>();

            try { 
            Console.WriteLine("\nHow many steps does this need?: ");
                int localsteps = int.Parse(Console.ReadLine());

                string steps = "";

                for (int i = 0; i < localsteps; i++)
                {
                    Console.WriteLine($"\nSTEPS {i + 1}: ");
                    steps = Console.ReadLine();
                    list.Add(steps);
                }
                //stores steps into steplist
                stpList = list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region foodgroup
        public void select() 
    {
            string foodGroup = "";

            Console.WriteLine("\nPlease choose a food group from the following:\n");

            Console.WriteLine("1: Starchy foods");

            Console.WriteLine("2: Vegetables and fruits");

            Console.WriteLine("3: Dry beans, peas, lentils and soya");

            Console.WriteLine("4: Chicken, fish, meat and eggs");

            Console.WriteLine("5: Milk and dairy products");

            Console.WriteLine("6: Fats and oil");

            Console.WriteLine("7: Water");

            //input is read and then refered to one of these cases
            string chosen = Console.ReadLine();
            foodGroup = chosen;

            try { 
            switch (chosen)
            {
                //options of choices above
                case "1":
                    Console.WriteLine("\nName of food group: Starchy foods");
                    break;

                case "2":
                    Console.WriteLine("\nName of food group: Vegetables and fruits");
                    break;

                case "3":
                    Console.WriteLine("\nName of food group: Dry beans, peas, lentils and soya\n");
                    break
                        ;
                case "4":
                    Console.WriteLine("\nName of food group: Chicken, fish, meat and eggs\n");
                    break;

                case "5":
                    Console.WriteLine("\nName of food group: Milk and dairy products\n");
                    break;

                case "6":
                    Console.WriteLine("\nName of food group: Fats and oil\n");
                    break;

                case "7":
                    Console.WriteLine("\nName of food group: Water\n");
                    return;

                default:
                    Console.WriteLine("INVALID OPTION! ");
                    break;

            }
                ingredientsList.Add(new ingredients()
                {
                    Foodgroup = chosen
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region for viewing recipe
        public void VIEWRECIPE()
        {
            string recipeName = "";

            // Sort recipes by name in alphabetical order
            recipeList.Sort((r1, r2) => string.Compare(r1.RecipeName1, r2.RecipeName1, StringComparison.Ordinal));

            // Display all the recipe names that were inputted by the user so the recipe knows which one to choose from
            foreach (COOKBOOK ig in recipeList)
            { 
                Console.WriteLine($"\nRECIPES: \n{ig.RecipeName1}");
            }

            // Prompt user 
            Console.WriteLine("\nWhich recipe details would you like to view?: ");
            recipeName = Console.ReadLine();

            try
            {
                int selectedBook = recipeList.FindIndex(recipe => string.Equals(recipe.RecipeName1, recipeName, StringComparison.OrdinalIgnoreCase));

                // Used to display all the recipe information stored
                if (selectedBook != -1)
                {
                    var rbook = recipeList[selectedBook]; // Selects the exact recipe

                    foreach (var ingredient in rbook.ingredients)
                    {
                       // Console.WriteLine(ingredient.ToString());
                        Console.WriteLine($"\nINGREDIENT INFORMATION(S):\n ===NAME OF INGREDIENT: {ingredient.Nameofingredient}\n ===NUMBER OF INGREDIENT(S): " +
                            $"{ingredient.Numofingred}\n ===QUANTITY: {ingredient.Sum}\n ===UNIT OF MEASURE: {ingredient.Measure}\n ====CALORIES: " +
                            $"{ingredient.Calories}\n ===FOODGROUP: {ingredient.Foodgroup}");
                        total += ingredient.Calories;
                        Console.WriteLine();
                    }

                    double totalCalories = rbook.TOTCAL();
                    Console.WriteLine($"Total Calories: {totalCalories}");

                    // Displays all the steps inputted
                    if (stpList.Count > 0)
                    {
                        Console.WriteLine("\nsteps:");
                        foreach (string step in stpList)
                        {
                            Console.WriteLine($"=== {step}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No steps found.");
                    }
                }
                // Notifies the user that they have entered a wrong recipe
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
        public double TOTCAL()   
        {
            double totalCalories = 0;

            //calcultes and displays everything calorie related
            foreach (ingredients ingredient in ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }
        #endregion

        #region Event handler method 
        public static void HandleRecipeNotification(string message)
        {
            Console.WriteLine(message);
        }
        #endregion
    }
}




