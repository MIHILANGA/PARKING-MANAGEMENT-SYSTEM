using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING_MANAGEMENT_SYSTEM
{
    public partial class SlotForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public SlotForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeScreen s = new WelcomeScreen();
            s.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    var chk = db.tableSlots.Where(o => o.Slot_No == sk || o.Location == sk).ToList();
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

        public void reset()
        {
            textsno.Text = "";
            textlocations.Text = "";
            labelid.Text = "";
        }

        public void load()
        {
            var lod = db.tableSlots.ToList();
            dataGridView1.DataSource = lod;
        }
      

        private void SlotForm_Load(object sender, EventArgs e)
        {
            load();

        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textsno.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textlocations.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }

     

        

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null)
                {


                    if (MessageBox.Show("Do you want to delete record!..", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(labelid.Text);
                        var s = db.tableSlots.Where(o => o.ID == st).FirstOrDefault();
                        db.tableSlots.DeleteOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Delete");
                        reset();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textsno.Text != null & textlocations.Text != null)
                {
                    string sno = textsno.Text;
                    var chk = db.tableSlots.Where(o => o.Slot_No == sno).FirstOrDefault();
                    if (chk == null)
                    {




                        tableSlot s = new tableSlot();
                        s.Slot_No = textsno.Text;
                        s.Location = textlocations.Text;
                        db.tableSlots.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Inserted");
                        reset();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("With this name slot already added..");
                    }
                }
                else
                {
                    MessageBox.Show("Slot no or location box empty....data not proccessed try again....!");
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
                if (labelid.Text != null & textsno.Text != null & textlocations.Text != null)
                {


                    if (MessageBox.Show("Do you want to edit record!..", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sno = textsno.Text;
                        var chk = db.tableSlots.Where(o => o.Slot_No == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tableSlots.Where(o => o.ID == st).FirstOrDefault();

                            s.Slot_No = textsno.Text;
                            s.Location = textlocations.Text;

                            db.tableSlots.InsertOnSubmit(s);
                            db.SubmitChanges();
                            MessageBox.Show("Data Updated");
                            reset();
                            load();
                        }

                        else
                        {
                            MessageBox.Show("With this name slot already added..");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Slot no or location box empty....data not proccessed try again....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WelcomeScreen s = new WelcomeScreen();
            s.Show();
            this.Hide();
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

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textsno.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textlocations.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }
    }
}
