
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class created to store getters and setters for information related to the recipe 
namespace POE_PART_1_ST10082757_GROUP_3_PROG6221
{ 
    public class recipe
    {
        //list for my cookbook class and ingredients class
        public List<COOKBOOK> cookies { get; set; }

        public List<ingredients> product = new List<ingredients>();


        private string steps = "";
        private int stepsno = 0;
        private string nameofrecipe = "";

        public string Steps { get => steps; set => steps = value; }
        public int Stepsno { get => stepsno; set => stepsno = value; }
        public string Nameofrecipe { get => nameofrecipe; set => nameofrecipe = value; }


    }
}




