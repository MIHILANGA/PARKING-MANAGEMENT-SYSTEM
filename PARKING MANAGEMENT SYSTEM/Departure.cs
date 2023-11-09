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
    public partial class Departure : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Departure()
        {
            InitializeComponent();
        }

        private void load()
        {

            var dblod = db.tableDepartures.ToList();
            dataGridView1.DataSource = dblod;
            comboBox2.DataSource = db.tableArrivals.ToList();
            comboBox2.ValueMember = "Car_No";
            comboBox2.DisplayMember = "Car_No";
        }
        private void comboBoxcarno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tableArrival obj = comboBox2.SelectedItem as tableArrival;
                if (obj != null)
                {
                    labeldname.Text = obj.Driver_Name.ToString();
                    labeltype.Text = obj.Category.ToString();
                    labelptime.Text = obj.Stay_Time.ToString();
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
                    var chk = db.tableDepartures.Where(o => o.Driver == sk || o.Car_No == sk || o.Type == sk).ToList();
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
        
        private void Departure_Load(object sender, EventArgs e)
        {
            try
            {
                var dblod = db.tableDepartures.ToList();
                dataGridView1.DataSource = dblod;
                comboBox2.DataSource = db.tableArrivals.ToList();
                comboBox2.ValueMember = "Car_No";
                comboBox2.DisplayMember = "Car_No";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void textstime_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & comboBox2.Text != null & labeldname.Text != null & labelptime.Text != null & labeltype.Text != null)
                {


                    tableDeparture s = new tableDeparture();
                    s.Car_No = comboBox2.Text;
                    s.Driver = labeldname.Text;
                    s.Type = labeltype.Text;
                    s.P_Time = labelptime.Text;
                   

                    decimal srt = Convert.ToDecimal(labelptime.Text);
                    decimal amt = Convert.ToDecimal(textpamount.Text);
                    decimal amttotal = srt * amt;
                    s.Amount = amttotal;
                    s.Departure_Time = DateTime.Now;
                    db.tableDepartures.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Departured Succsessfully...");

                    load();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & comboBox2.Text != null & labeldname.Text != null & labelptime.Text != null & labeltype.Text != null)
                {


                    if (MessageBox.Show("Do you want to edit record!..", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(labelid.Text);
                        var s = db.tableDepartures.Where(o => o.ID == st).FirstOrDefault();


                        s.Car_No = comboBox2.Text;
                        s.Driver = labeldname.Text;
                        s.Type = labeltype.Text;
                        s.P_Time = labelptime.Text;
                       

                        decimal srt = Convert.ToDecimal(labelptime.Text);
                        decimal amt = Convert.ToDecimal(textpamount.Text);
                        decimal amttotal = srt * amt;
                        s.Amount = amttotal;
                        s.Departure_Time = DateTime.Now;

                        db.SubmitChanges();
                        MessageBox.Show("Data Updated");

                        load();
                    }

                    else
                    {
                        MessageBox.Show("With this name slot already booked...");
                    }

                }
                else
                {
                    MessageBox.Show("Recod not selected and data not proccessed try again....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Amount not enterd,enter amount and try to update...");
            }
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
                        var s = db.tableDepartures.Where(o => o.ID == st).FirstOrDefault();
                        db.tableDepartures.DeleteOnSubmit(s);
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

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeScreen w = new WelcomeScreen();
            w.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            labelid.Text = dataGridView1.Rows[indexrow].Cells[1].Value.ToString();
            lbldtime.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            lblpfee.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tableArrival obj = comboBox2.SelectedItem as tableArrival;
                if (obj != null)
                {
                    labeldname.Text = obj.Driver_Name.ToString();
                    labeltype.Text = obj.Category.ToString();
                    labelptime.Text = obj.Stay_Time.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void lbldtime_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexrow = e.RowIndex;
            labelid.Text = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            lbldtime.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            lblpfee.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();
        }
    }
}
