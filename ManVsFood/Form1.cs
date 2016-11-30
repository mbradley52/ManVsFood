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
                FoodItems = (FoodItemCollection)serializer.Deserialize(reader);
                
                foreach (var item in FoodItems.Items)
                {
                    //add items from the database into the list box
                    lb_Items.Items.Add(item);
                }
            }
        }
        //More XML database stuff, <items> root 
        [XmlRoot("items")]
        public class FoodItemCollection
        {
            //<item> element
            [XmlElement("item")]
            //make a list
            public List<FoodItem> Items { get; set; }
        }
        
        public class FoodItem
        {
            //declare variable names, get them from FoodItemsDatabase.xml
  
            public string challengename { get; set; }
            public string description { get; set; }
            public int calories { get; set; }
            public double price { get; set; }
            public double duration { get; set; }
            public string image { get; set; }
        }
        

        //buttons
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Opens a new form and adds a new challenge item to lb_Items
            Form_ChallengeInfo challengeInfo = new Form_ChallengeInfo();
            challengeInfo.ShowDialog();

           if (challengeInfo.DialogSave == true)
            {
                FoodItem newitem = challengeInfo.createItem;
                lb_Items.Items.Add(newitem);
                FoodItems.Items.Add(newitem);
                XmlWriterSettings settings = new XmlWriterSettings();
                //add xml settings here - fix word wrap issue
                //settings.


                using (XmlWriter writer = XmlWriter.Create("..\\..\\Resources\\FoodItemDatabase.xml", settings))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(FoodItemCollection));
                    serializer.Serialize(writer, FoodItems);
                }
      
            }
        }
       

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to exit?", "Confirming",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.Close();
            }

        }
        double challengeTimer;
        private void lb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for debugging
            int a = 0;
            //What we do when we select an item
            var lbox = sender as ListBox;
            if (lbox != null)
            {
                if (lbox.SelectedItem != null)
                {
                                                     
                    //Get the loaded XML data into a variable "challenge"
                    var challenge = lbox.SelectedItem as FoodItem;
                    //display the information of selected items in appropriate labels

                    //Challenge Duration display
                    lbl_ChallengeTime.Text = (challenge.duration * 60 ).ToString()+ " minute(s)";
                    //Gets the time for the challenge
                    challengeTimer = challenge.duration;
                    //Displays the cost of the challenge
                    lbl_Cost.Text = "$" + challenge.price.ToString("F2");
                    //display an image
                    picBox.ImageLocation = challenge.image;
                    //Needed for when a new item gets selected the timer stops.
                    timer1.Stop();
                    // Initial timer display
                    timerDisplay.Text = (challenge.duration *60).ToString() + " minutes" ;
                    // Description display
                    descriptionLabel.Text = challenge.description.ToString();
                 }

            }
        }


        private void lb_AddedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_MVF_Load(object sender, EventArgs e)
        {

        }
        //Startcheck makes sure the timer is not running when another item is selected. Before the timer would auto start.
        bool startCheck = false;
        double displayTimer;
        //paused boolean controls the timer for pauses
        bool paused = false;
        double minutes = 0;
        double seconds = 0;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (paused == false)
            { 
                timerDisplay.Text = "";
                //Conver minutes to seconds
                displayTimer = challengeTimer;
                // Times 60 to convert to minutes from hours
                minutes = displayTimer * 60;
                startCheck = true;
                // Start the correct time
                minutes--;
                seconds = 59;
                timerDisplay.Text = timerDisplay.Text = minutes + " minutes & \n" + seconds + " seconds";
            }

            timer1.Start();
         }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // pause and startcheck are variables to control the timer properly
            paused = false;
            if (startCheck == true)
            { 
                
                if (minutes >=0 && seconds > 0)
                {             
                    seconds--;
                    //Stop the timer when the timit limit is up
                    if(minutes == 0 && seconds == 0)
                    {
                        timerDisplay.Text = minutes + " minutes & \n" + seconds + " seconds";
                        MessageBox.Show("TIME IS UP");
                        startCheck = false;
                        timer1.Stop();
                    }
                    //decrement the minutes when seconds hit 0
                    else if (seconds <= 0)
                    {
                        minutes--;
                        seconds = seconds +60;
                        timerDisplay.Text = minutes + " minutes & \n" + seconds + " seconds";
                    }
                    //update timer display when the other if statements have not been triggered. 
                    else
                    {
                        timerDisplay.Text = minutes + " minutes & \n" + seconds + " seconds";
                    }
                }               
            }
            else
            {
                startCheck = false;
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timerDisplay.Text = "";
            lbl_ChallengeTime.Text = "";
            lbl_Cost.Text = "";
            descriptionLabel.Text = "";
            timer1.Stop();
            paused = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            paused = true;
        }
    }
}
