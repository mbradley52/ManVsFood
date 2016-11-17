using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ManVsFood
{
    public partial class Form_MVF : Form
    {
        private FoodItemCollection FoodItems;
         
            
        public Form_MVF()
        {
            InitializeComponent();
            //Loads our database into the form - using XML serializer 
            using (XmlReader reader = XmlReader.Create("..\\..\\Resources\\FoodItemDatabase.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(FoodItemCollection));
                FoodItemCollection allItems = (FoodItemCollection)serializer.Deserialize(reader);
                
                foreach (var item in allItems.Items)
                {
                    lb_Items.Items.Add(item);
                }
            }
        }
        //More XML database stuff
        [XmlRoot("items")]
        public class FoodItemCollection
        {
            [XmlElement("item")]
            public List<FoodItem> Items { get; set; }
        }
        
        public class FoodItem
        {
            //declare variable names, get them from FoodItemsDatabase.xml
            public double duration { get; set; }
            public string challengename { get; set; }
            public int calories { get; set; }
            public string image { get; set; }
            public double price { get; set; }
        }
        //end XML database stuff

        //buttons
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Adds items from lb_Items to lb_AddedItems
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //Removes items from lb_AddedItems and Adds them to lb_Items
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //idk my bff jill - do we even need a reset?
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //Starts a timer according to the selected item in lb_AddedItems
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //exits the app
            this.Close();
            //maybe add a confirmation dialogue

            //MessageBox.Show("Are you sure you want ot Exit?", "Exit", MessageBoxButtons.YesNo);

        }
        //end buttons


        //Listboxes
        private void lb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

            int a = 0;
            var lbox = sender as ListBox;
            if (lbox != null)
            {
                if (lbox.SelectedItem != null)
                {
                    //display the information of selected items
                    var challenge = lbox.SelectedItem as FoodItem;
                    lbl_ChallengeTime.Text = challenge.duration.ToString();
                    lbl_Cost.Text = challenge.price.ToString();
                    //figure out how to set the image
                    //picBox.Image = challenge.image;
                }
               
            }
        }


        private void lb_AddedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //end list boxes



    }
}
