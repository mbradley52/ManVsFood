using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManVsFood
{
    public partial class Form_MVF : Form
    {
        public Form_MVF()
        {
            InitializeComponent();
        }

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
            //idk my bff jill
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            // Start the timer.
            timeLeft = 30;
            timerDisplay.Text = "30 seconds";
            timer1.Start();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //exits the app
            this.Close();
            //maybe add a confirmation dialogue

            //MessageBox.Show("Are you sure you want ot Exit?", "Exit", MessageBoxButtons.YesNo);

        }
        int timeLeft;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timerDisplay.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timerDisplay.Text = "Time's up!";
               
                btn_Start.Enabled = true;
            }
        }

        private void timerDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
