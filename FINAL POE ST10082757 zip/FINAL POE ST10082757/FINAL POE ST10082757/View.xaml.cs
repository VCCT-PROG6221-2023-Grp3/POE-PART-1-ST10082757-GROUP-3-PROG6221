using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FINAL_POE_ST10082757;
using POE_PART_2_ST10082757_GROUP_3_PROG6221;

namespace FINAL_POE_ST10082757
{
    public partial class View : Window
    {
        public static View instance;
        public COOKBOOK CookbookData { get; set; }

        public View()
        {
            InitializeComponent();
            Loaded += View_Loaded;
            instance = this;


        }

        #region for deleting
        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region for exiting
        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region for adding
        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region viewing the recipes alphabetically
        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            if (CookbookData != null)
            {
                List<string> items = CookbookData.recipeList.Select(recipe => recipe.RecipeName1).ToList();
                Steven.ItemsSource = items;
            }
        }
        #endregion

        #region for viewing the reciope details
        private void Viwings_Click(object sender, RoutedEventArgs e)
        {
            //finds and compares the recipe names in order to display the correct one
            while (true) 
            { 
            int selectedBook = CookbookData.recipeList.FindIndex(recipe => string.Equals(recipe.RecipeName1, Steven.Text, StringComparison.OrdinalIgnoreCase));

                if (selectedBook != -1)
                {
                    var rbook = CookbookData.recipeList[selectedBook];
                    string message = "Entered Data:\n";

                    foreach (var data in rbook.ingredients)
                    {
                        message += $"Measure: {data.Measure}\n";
                        message += $"Sum: {data.Sum}\n";
                        message += $"Ingredient Name: {data.Nameofingredient}\n";
                        message += $"Calories: {data.Calories}\n";
                        message += $"Food Group: {data.Foodgroup}\n";
                        message += $"Number of Ingredients: {data.Numofingred}\n";
                        message += $"Total Calories: {data.Totalcalories}\n";
                        message += "-----------------\n";
                    }

                    george.Text = selectedBook.ToString();
                    //george.Text = message;
                    
                }
               
            }

        }
        #endregion
    
        #region refreshes the textbox
        private void Rbutton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        #endregion
    }
}
