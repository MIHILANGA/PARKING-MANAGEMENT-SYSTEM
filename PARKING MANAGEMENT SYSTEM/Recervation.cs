using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING_MANAGEMENT_SYSTEM
{
    public partial class Recervation : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public PrintDocument PrintDocument1 { get; private set; }

        public Recervation()
        {
            InitializeComponent();
        }

        private void Recervation_Load(object sender, EventArgs e)
        {
            var ld = db.tableDepartures.ToList();
            dataGridView1.DataSource = ld;
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeScreen s = new WelcomeScreen();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter p=new DGVPrinter();
            p.printDocument = PrintDocument1;
            p.Title = "Final Bill";
            p.SubTitle = string.Format("Date:{0}", DateTime.Now);

            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            p.printDocument = PrintDocument1;
            p.PageNumbers = true;

            p.PageNumberInHeader = true;

            p.PorportionalColumns= true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "Vehicle Parking System";

            p.FooterSpacing = 15;
            p.PrintDataGridView(dataGridView1);

            WelcomeScreen s = new WelcomeScreen();
            s.Show();
            this.Hide();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            var ld = db.tableDepartures.ToList();
            dataGridView1.DataSource = ld;
            Display();
        }
        public void Display()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

            }
            lblamount.Text = sum.ToString();

            var slot = db.tableSlots.Count();
            labelcp.Text = slot.ToString();
            var pca = db.tableArrivals.Count();
            labelarrive.Text = pca.ToString();

            var pca1 = db.tableDepartures.Count();
            lbltotald.Text = pca1.ToString();
        }

        private void load()
        {
            var ld = db.tableDepartures.ToList();
            dataGridView1.DataSource = ld;
        }

        private void textsno_TextChanged(object sender, EventArgs e)
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
                        Display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
