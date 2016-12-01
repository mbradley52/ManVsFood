using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManVsFood
{
   

    public partial class Form_ChallengeInfo : Form
    {
        public string path;
        public bool DialogSave { get; set; }
        public Form_MVF.FoodItem createItem {
            get {
                return new Form_MVF.FoodItem()
                {
                    challengename = challenge,
                    description = descriptionVar,
                    calories = caloriesVar,
                    price = priceVar,
                    duration = durationVar, 
                    image = txt2_Image.Text                   
                };
                }
        }  

        public Form_ChallengeInfo()
        {
            InitializeComponent();
        }

        private void btn2_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();string fullPath = ofd.FileName;
                string fileName = ofd.SafeFileName;
                path = fullPath.Replace(fileName, "");
                txt2_Image.Text = path + fileName;
                
            }
        }
        
        string descriptionVar, challenge;
        int durationVar, caloriesVar;
        double priceVar;
        private void btn2_Save_Click(object sender, EventArgs e)
        {
            DialogSave = true;
            try
            {
                descriptionVar = txt2_Description.Text.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid entry for Description" );
                txt2_Description.Clear();
                txt2_Description.Focus();
                DialogSave = false;
            }
            try
            {
                caloriesVar = int.Parse(txt2_Calories.Text);
            }
            catch
            {
                MessageBox.Show("Invalid entry for Calories");
                txt2_Calories.Clear();
                txt2_Calories.Focus();
                DialogSave = false;
            }
            try
            {
                challenge = txt_ChallengeName.Text.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid entry for Challenge Name");
                DialogSave = false;
                txt2_Calories.Clear();
                txt2_Calories.Focus();
            }
            try
            {
                durationVar = int.Parse(durationBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid entry for Duration");
                DialogSave = false;
                durationBox.Clear();
                durationBox.Focus();
                
            }
            try
            {
                priceVar = double.Parse(txt2_Price.Text);
            }
            catch
            {
                MessageBox.Show("Invalid entry for the Price");
                txt2_Price.Clear();
                txt2_Price.Focus();
                DialogSave = false;
            }


            this.Close();
            
        }

        private void btn2_Exit_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to exit?", "Confirming",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
