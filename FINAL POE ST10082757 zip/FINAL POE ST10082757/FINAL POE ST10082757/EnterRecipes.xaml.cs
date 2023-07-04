using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using FINAL_POE_ST10082757;
using POE_PART_2_ST10082757_GROUP_3_PROG6221;

namespace FINAL_POE_ST10082757
{
    
    public partial class EnterRecipes : System.Windows.Window
    {

        public static EnterRecipes instance;

        private COOKBOOK cookbook = new COOKBOOK();
        public List<string> items;
        View view = new View(); 
        string user = "";

        #region stores food group dropdown and initialisation 
        public EnterRecipes()
        {
            //runns this class
            InitializeComponent();
            instance = this;

            //stores food groups
            List<string> list = new List<string>
            {
                "Starchy foods",
                "Vegetables and fruits",
                "Dry beans, peas, lentils and soya",
                "Chicken, fish, meat and eggs",
                "Milk and dairy products",
                "Fats and oil",
                "Water"
            };

            items = new List<string>();
        }
        #endregion

        #region for exit button
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //gives user option to cancel or confirm 
            DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure you want to Exit ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                System.Windows.MessageBox.Show("Thank You!!!");
            }
        }
        #endregion

        #region saving
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //hides page after save button is clicked
            this.Hide();

            //asks user to confirm their save
            System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show("Would you like to save the data", "Save Prompt", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == System.Windows.MessageBoxResult.Yes)
            {
                //lists used to store data
                List<ingredients> enteredData = new List<ingredients>();
                List<string> stepList = new List<string>();

                // Iterate through the items in the ListView
                foreach (var item in VariableListView.Items)
                {
                    // Retrieve the data item and cast it to ingredients
                    if (item is ingredients variable)
                    {
                        // Add the ingredients to the collection
                        enteredData.Add(variable);
                    }
                }

                foreach (var item in StepListView.Items)
                {
                    // Retrieve the data item and cast it to string
                    if (item is string step)
                    {
                        // Add the step to the list
                        stepList.Add(step);
                    }
                }

                //stores the following values in the list
                cookbook.recipeList.Add(new COOKBOOK() { RecipeName1 = Recname.Text, ingredients = enteredData, stpList = stepList });
                double Calories = 0;
                string ingredientExceeding300 = null;

                //exceeding 300 calories calculation 
                foreach (var data in enteredData)
                {
                    Calories += data.Calories;

                    if (data.Calories > 300)
                    {
                        ingredientExceeding300 = data.Nameofingredient;
                    }
                }

                VariableListView.Items.Clear();
                StepListView.Items.Clear();

                //displays after user saves
                System.Windows.MessageBox.Show("Data saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                //notification after user enters more than 300 calories
                if (Calories > 300 && !string.IsNullOrEmpty(ingredientExceeding300))
                {
                    string message1 = $"Total calories exceed 300! Ingredient: {ingredientExceeding300}";
                    System.Windows.MessageBox.Show(message1, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                string message = "Entered Data:\n";

                //displays to the user the details they have entered
                foreach (var data in enteredData)
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

                System.Windows.MessageBox.Show(message, "Entered Data", MessageBoxButton.OK, MessageBoxImage.Information);

               
            }
        }
        #endregion

        #region for deleting
        //method to delete, connecetd to delete button
        private void Deletebtn1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to delete", "View Prompt", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == System.Windows.MessageBoxResult.Yes)
            {
                cookbook.DELETE();
                System.Windows.MessageBox.Show("Data ready", "delete ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

            }
        }
        #endregion

        #region for exiting
        private void exitbtn1_Click(object sender, RoutedEventArgs e)
        {
            //method tio exit, connected to exit button
            System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to exit application", "Exit Prompt", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == System.Windows.MessageBoxResult.Yes)
            {

                System.Windows.MessageBox.Show("Data ready", "bye", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);
            }
            else
            {

            }
        }
        #endregion

        #region for viewing
        private void Viewbtn1_Click(object sender, RoutedEventArgs e)
        {
            //method to view
            if (view == null || !view.IsVisible)
            {
                view = new View();
                view.Closed += (s, args) => view = null; // Handle the Closed event to set the reference to null
                view.Show();
            }
            else
            {
                // The window is already open
                view.Activate();
            }
        }
        #endregion

        #region adding recipe
        //method to add recipes
        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            ingredients variable = new ingredients();
            VariableListView.Items.Add(variable);
        }
        #endregion

        #region adding a step
        //method to add steps
        private void AddStepBtn_Click(object sender, RoutedEventArgs e)
        {
            string newStep = "";
            StepListView.Items.Add(newStep);
            StepListView.ScrollIntoView(newStep);
        }

        #endregion
    }
}
