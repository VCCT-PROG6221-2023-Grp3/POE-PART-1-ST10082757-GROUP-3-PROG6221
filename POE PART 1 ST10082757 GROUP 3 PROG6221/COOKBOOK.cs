using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{
    delegate double Delegating(double Calories);
    public delegate void RecipeCaloriesExceededHandler(string Name, int totalCalories);

    public class COOKBOOK
    {
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

        public COOKBOOK()
        {
            ingredients = new List<ingredients>();
            stpList = new List<string>();
        }

        public string RecipeName1 { get => RecipeName; set => RecipeName = value; }


        #region
        public void DELETE()
        {
            recipe01.Clear();
            ingredientsList.Clear();
            recipeList.Clear();
            stpList.Clear();
            ingredients.Clear();
            Console.WriteLine($"\nDELETE COMPLETE, choose option 2 to confirm\n");
        }
        #endregion

        #region
        public void SCALE()
        {
            Console.WriteLine("\nEnter 1 of the scaling factors using a comma; 0,5 or 2 or 3 \n");
            // double scale;
            double SumAndextra;

            //setting the input to double
            scale = double.Parse(Console.ReadLine());

            if (scale != 0.5 && scale != 2 && scale != 3)

            {
                Console.WriteLine("\nINVALID!\n");
                SCALE();
                return;
            }
            else
            {
                for (int i = 0; i < ingredientsList.Count; i++)
                {

                    ingredientsList[i].Sum *= scale;
                }

            }
            Console.WriteLine($"\nSCALING COMPLETE, choose option 2 to confirm\n");


        }

        #endregion

        #region 
        public void RESET()
        {


            for (int i = 0; i < ingredientsList.Count; i++)
            {

                ingredientsList[i].Sum /= scale;
            }
        }
        #endregion

        #region
        public void decide()
        {
            int choice = 0;

            Console.Write("\n0 = NOT YET\n1 = DONE \n");
            choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                ADDINGRECIPE();
            }
        }
        #endregion

        #region
        public void ADDINGRECIPE()
        {
            List<string> list = new List<string>();

            string Nameofing = "";


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

                    if (cal > 300)
                    {
                        CaloriesExceeded?.Invoke(recipeName, cal);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning: The total calories of recipe " + recipeName + " exceed 300!");
                        Console.ResetColor();
                    }

                    Console.WriteLine("\nName of food group: ");
                    string foodGroup = Console.ReadLine();

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
            stpList = list;
            recipeList.Add(new COOKBOOK() { RecipeName1 = recipeName, ingredients = ingredientsList, stpList = list });

        }
        #endregion

        #region
        public void VIEWRECIPE()
        {

            string recipeName = "";

            foreach (COOKBOOK ig in recipeList)
            {
                Console.WriteLine($"\nRECIPES: \n{ig.RecipeName1}");
            }



            Console.WriteLine("\nWhich recipe details would you like to view?: ");
            recipeName = Console.ReadLine();
            try
            {
                COOKBOOK LookForRecipe = recipeList.FirstOrDefault(x => x.RecipeName1 == recipeName);

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
                    TOTCAL(total);
                    foreach (string step in stpList)
                    {
                        Console.WriteLine($"\n ===STEPS: {step}");
                    }
                }
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

        #region
        public void TOTCAL(double calories)
        {
            double totalCalories = calories;

            Console.WriteLine("Total Calories: " + totalCalories);

            if (totalCalories > 300)
            {
                Console.WriteLine("This recipe exceeds 300 calories!");
            }
        }

        #endregion
    }
}




