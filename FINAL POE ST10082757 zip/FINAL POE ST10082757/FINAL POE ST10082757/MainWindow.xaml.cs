using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using POE_PART_2_ST10082757_GROUP_3_PROG6221;

namespace FINAL_POE_ST10082757
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        EnterRecipes NewRecipe = new EnterRecipes();
        COOKBOOK book = new COOKBOOK();
        View view = new View();
        Scale scale = new Scale();
        

        public MainWindow()
        {
            InitializeComponent();

        }


        #region for exiting
        //method to exit application
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to exit application", "Exit Prompt", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == System.Windows.MessageBoxResult.Yes)
            {
                
                System.Windows.MessageBox.Show("Data ready", "View Recipe", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);    
            }
            else
            {
                
            }
        }
        #endregion

        #region for taking user to delete option
        //asks the user if they are sure they want to delete
        private void Delete(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to view recipes", "View Prompt", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == System.Windows.MessageBoxResult.Yes)
            {
                book.DELETE();
                System.Windows.MessageBox.Show("Data ready", "View Recipe", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
               
            }
        }

        #endregion

        #region for adding
        //takes user to add recipies 
        private void Add(object sender, RoutedEventArgs e)
        {
            if (NewRecipe == null || !NewRecipe.IsVisible)
            {
                NewRecipe = new EnterRecipes();
                NewRecipe.Closed += (s, args) => NewRecipe = null; // Handle the Closed event to set the reference to null
                NewRecipe.Show();
            }
            else
            {
                // The window is already open
                NewRecipe.Activate();
            }
        }
        #endregion

        #region for adding
        //takes user to add recipies 
        private void Add2(object sender, RoutedEventArgs e)
        {
            if (NewRecipe == null || !NewRecipe.IsVisible)
            {
                NewRecipe = new EnterRecipes(); 
                NewRecipe.Closed += (s, args) => NewRecipe = null; // Handle the Closed event to set the reference to null
                NewRecipe.Show();
            }
            else
            {
                // The window is already open
                NewRecipe.Activate();
            }
        }
        #endregion

        #region for adding
        //takes user to add recipies 
        private void View2(object sender, RoutedEventArgs e)
        {
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

        #region for taking user to delete option
        //asks the user if they are sure they want to delete
        private void Delete2(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to view recipes", "View Prompt", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == System.Windows.MessageBoxResult.Yes)
            {
                book.DELETE();
                System.Windows.MessageBox.Show("Data ready", "View Recipe", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                
            }
        }
        #endregion

        #region for exiting
        //method to exit application
        private void Exit_ClickS(object sender, RoutedEventArgs e)
        {
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

        #region for closing the application
        //ends application
        private void closing(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        #region for scaling
        //takes user to scaling
        private void Scaling2(object sender, RoutedEventArgs e)
        {
            if (scale == null || !scale.IsVisible)
            {
                scale = new Scale();
                scale.Closed += (s, args) => scale = null; // Handle the Closed event to set the reference to null
                scale.Show();
            }
            else
            {
                // The window is already open
                scale.Activate();
            }
        }
        #endregion

        #region viewing button

        private void Viewbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region adding button
        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
