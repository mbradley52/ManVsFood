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
            //Starts a timer according to the selected item in lb_AddedItems
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //exits the app
            this.Close();
            //maybe add a confirmation dialogue

            //MessageBox.Show("Are you sure you want ot Exit?", "Exit", MessageBoxButtons.YesNo);

        }
    }
}
