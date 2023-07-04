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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FINAL_POE_ST10082757
{
    /// <summary>
    /// Interaction logic for Scale.xaml
    /// </summary>
    public partial class Scale : Window
    {
        public double scaling { get; private set; }

        

        COOKBOOK book = new COOKBOOK();

        public Scale()
        {
            InitializeComponent(); 
            DataContext = this;
            
        }
        #region for scaling
        //uses the combobox to display the correct information and store it
        private void ScaleFactorDialog_OK_Click(object sender, RoutedEventArgs e)
        {
            if (ScaleFactorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string scaleFactorText = selectedItem.Content.ToString();
                if (double.TryParse(scaleFactorText, out double scaleFactor))
                {
                    scaling = scaleFactor;
                    DialogResult = true;
                }
            }
        }
        #endregion


        #region leaving page
        //takes user backw to main window
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure you want to Exit ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                System.Windows.MessageBox.Show("Thank You!!!");
                this.Close();
                this.Hide();
            }
        }
        #endregion

        #region saving scaling choice
        //saves combobox option chosen by user
        private void Save_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure you want to save ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                System.Windows.MessageBox.Show("Thank You!!!");
                this.Close();
                this.Hide();
            }
        }
        #endregion
    }
}
