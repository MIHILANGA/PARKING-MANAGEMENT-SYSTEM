using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING_MANAGEMENT_SYSTEM
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void arrivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arrival wc = new Arrival();
            wc.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 wc = new Form1();
            wc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlotForm wc = new SlotForm();
            wc.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arrival wc=new Arrival();
            wc.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departure wc=new Departure();
            wc.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Recervation wc=new Recervation();
            wc.Show();
            this.Close();
        }
    }
}
