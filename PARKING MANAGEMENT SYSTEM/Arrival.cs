using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING_MANAGEMENT_SYSTEM
{
    public partial class Arrival : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Arrival()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeScreen w = new WelcomeScreen();
            w.Show();
            this.Hide();
        }
        public void load()
        {
            var ld = db.tableArrivals.ToList();
            dataGridView1.DataSource = ld;
            labelid.Text = "";
            textdriver.Text = "";
            textcar.Text = "";
            textstime.Text = "";
            checkedListBox1.Text = "";

            var total = db.tableArrivals.Count();
            lbltotalin.Text = total.ToString();
        }
        private void Arrival_Load(object sender, EventArgs e)
        {
            load();
            comboBox1.DataSource = db.tableSlots.ToList();
            comboBox1.ValueMember = "Slot_No";
            comboBox1.DisplayMember = "Slot_No";
        }

       

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textdriver.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textcar.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            lblcarno.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            textstime.Text = dataGridView1.Rows[ir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ir].Cells[4].Value.ToString();
            checkedListBox1.Text = dataGridView1.Rows[ir].Cells[5].Value.ToString();
            lblarrivaltm.Text = dataGridView1.Rows[ir].Cells[6].Value.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textdriver.Text != null & textcar.Text != null & textstime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {
                    string sno = textcar.Text;
                    var chk = db.tableArrivals.Where(o => o.Car_No == sno).FirstOrDefault();
                    if (chk == null)
                    {




                        tableArrival s = new tableArrival();
                        s.Driver_Name = textdriver.Text;
                        s.Car_No = textcar.Text;
                        s.Category = checkedListBox1.Text;
                        s.Stay_Time = textstime.Text;
                        s.Selected_Slot = comboBox1.Text;
                        s.A_Time = DateTime.Now;
                        db.tableArrivals.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Park Succsessfully...");

                        load();
                    }
                    else
                    {
                        MessageBox.Show("This car number already added...");
                    }
                }
                else
                {
                    MessageBox.Show("empty boxes . Firstly fill details....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                load();
            }
            else
            {
                searchData();
            }
        }
        public void searchData()
        {

            try
            {
                if (textsearch.Text != null)
                {
                    string sk = textsearch.Text;
                    var chk = db.tableArrivals.Where(o => o.Driver_Name == sk || o.Car_No == sk || o.Category == sk).ToList();
                    if (chk != null)
                    {

                        dataGridView1.DataSource = chk;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       

       

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            WelcomeScreen w = new WelcomeScreen();
            w.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null)
                {


                    if (MessageBox.Show("Do you want to delete record!..", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(labelid.Text);
                        var s = db.tableArrivals.Where(o => o.ID == st).FirstOrDefault();
                        db.tableArrivals.DeleteOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Deleted");

                        load();

                    }
                }
                else
                {
                    MessageBox.Show("Recode not selected please select it and then delete....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & textdriver.Text != null & textcar.Text != null & textstime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {


                    if (MessageBox.Show("Do you want to edit record!..", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sno = textcar.Text;
                        var chk = db.tableArrivals.Where(o => o.Car_No == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tableArrivals.Where(o => o.ID == st).FirstOrDefault();

                            s.Driver_Name = textdriver.Text;
                            s.Car_No = textcar.Text;
                            s.Category = checkedListBox1.Text;
                            s.Stay_Time = textstime.Text;
                            s.Selected_Slot = comboBox1.Text;
                            s.A_Time = DateTime.Now;

                            db.SubmitChanges();
                            MessageBox.Show("Data Updated");

                            load();
                        }

                        else
                        {
                            MessageBox.Show("With this name slot already booked...");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Recod not selected and data not proccessed try again....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeScreen w = new WelcomeScreen();
            w.Show();
            this.Hide();
        }

        private void textsearch_TextChanged_1(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                load();
            }
            else
            {
                searchData();
            }
        }

        private void lblcarno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textdriver.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textcar.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            lblcarno.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            textstime.Text = dataGridView1.Rows[ir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ir].Cells[4].Value.ToString();
            checkedListBox1.Text = dataGridView1.Rows[ir].Cells[5].Value.ToString();
            lblarrivaltm.Text = dataGridView1.Rows[ir].Cells[6].Value.ToString();
        }
    }
}
