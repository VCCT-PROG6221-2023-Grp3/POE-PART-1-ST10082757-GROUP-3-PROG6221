using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{
    public class ingredients
    {
        private string measure = "";
        private double sum = 0;
        private string nameofingredient = "";
        private double calories = 0;
        private string foodgroup = "";
        private int numofingred = 0;
        private double totalcalories = 0;
        public string Measure { get => measure; set => measure = value; }
        public double Sum { get => sum; set => sum = value; }
        public string Nameofingredient { get => nameofingredient; set => nameofingredient = value; }
        public double Calories { get => calories; set => calories = value; }
        public string Foodgroup { get => foodgroup; set => foodgroup = value; }
        public int Numofingred { get => numofingred; set => numofingred = value; }
        public double Totalcalories { get => totalcalories; set => totalcalories = value; }
    }
}
