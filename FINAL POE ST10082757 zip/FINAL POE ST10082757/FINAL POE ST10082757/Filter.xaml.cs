using POE_PART_2_ST10082757_GROUP_3_PROG6221;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FINAL_POE_ST10082757
{
    /// <summary>
    /// Interaction logic for Filter.xaml
    /// </summary>
    public partial class Filter : Window
    {
        private List<COOKBOOK> recipeList;

        public Filter()
        {
            InitializeComponent();
            LoadRecipes();
        }

        #region storing the recipe
        //looking for recipe name in lists
        private void LoadRecipes()
        {
            // Load recipes from a data source (e.g., a database)
            recipeList = new List<COOKBOOK>
            {
                new COOKBOOK { RecipeName1 = ""}
            };

            // Populate the recipe list
            lstRecipes.ItemsSource = recipeList;
        }
        #endregion

        #region search
        //button to let user search using ingredient name
        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                // If the search query is empty, show all recipes
                lstRecipes.ItemsSource = recipeList;
            }
            else
            {
                var filteredRecipes = recipeList.Where(r =>
                 r.ingredientsList.Any(i => i != null && i.ToString().ToLower().Contains(searchQuery.ToLower())));

                lstRecipes.ItemsSource = filteredRecipes;



            }
        }

        #endregion
    }
   
}