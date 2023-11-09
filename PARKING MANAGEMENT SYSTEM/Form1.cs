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
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textemail.Text != null & textpassword.Text != null)
                {
                    var item = db.tableAccounts.Where(s => s.Email == textemail.Text & s.Password == textpassword.Text).FirstOrDefault();
                    if (item != null)
                    {
                        WelcomeScreen wc = new WelcomeScreen();
                        wc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your enter account details not exists....first creat your account");
                    }
                }
                else
                {
                    MessageBox.Show("Email or Password not valid.....! please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

      
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
