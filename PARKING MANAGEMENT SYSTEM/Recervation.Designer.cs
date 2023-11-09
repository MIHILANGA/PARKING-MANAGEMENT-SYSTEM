namespace PARKING_MANAGEMENT_SYSTEM
{
    partial class Recervation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recervation));
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltotald = new System.Windows.Forms.Label();
            this.labelarrive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelcp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(383, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 59);
            this.label1.TabIndex = 15;
            this.label1.Text = "RECERVATION BILL DETAILS DETAILS";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(779, 161);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(38, 29);
            this.labelid.TabIndex = 27;
            this.labelid.Text = "ID";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(243, 201);
            this.textsearch.MaximumSize = new System.Drawing.Size(500, 50);
            this.textsearch.MinimumSize = new System.Drawing.Size(200, 30);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(200, 22);
            this.textsearch.TabIndex = 26;
            this.textsearch.TextChanged += new System.EventHandler(this.textsno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(647, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "TOTAL DEPARTURED :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "SEARCH :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 262);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbltotald
            // 
            this.lbltotald.AutoSize = true;
            this.lbltotald.BackColor = System.Drawing.Color.Transparent;
            this.lbltotald.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotald.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbltotald.Location = new System.Drawing.Point(945, 204);
            this.lbltotald.Name = "lbltotald";
            this.lbltotald.Size = new System.Drawing.Size(27, 29);
            this.lbltotald.TabIndex = 28;
            this.lbltotald.Text = "0";
            // 
            // labelarrive
            // 
            this.labelarrive.AutoSize = true;
            this.labelarrive.BackColor = System.Drawing.Color.Transparent;
            this.labelarrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelarrive.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelarrive.Location = new System.Drawing.Point(1151, 204);
            this.labelarrive.Name = "labelarrive";
            this.labelarrive.Size = new System.Drawing.Size(27, 29);
            this.labelarrive.TabIndex = 30;
            this.labelarrive.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(1001, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "TOTAL IN :";
            // 
            // labelcp
            // 
            this.labelcp.AutoSize = true;
            this.labelcp.BackColor = System.Drawing.Color.Transparent;
            this.labelcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcp.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelcp.Location = new System.Drawing.Point(1373, 204);
            this.labelcp.Name = "labelcp";
            this.labelcp.Size = new System.Drawing.Size(27, 29);
            this.labelcp.TabIndex = 32;
            this.labelcp.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(1214, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "CAPACITY :";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.Color.Transparent;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblamount.Location = new System.Drawing.Point(835, 687);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(36, 38);
            this.lblamount.TabIndex = 34;
            this.lblamount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(362, 685);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(424, 38);
            this.label10.TabIndex = 33;
            this.label10.Text = "DEPARTURED AMOUNT:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(53, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 138);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1156, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 113);
            this.button2.TabIndex = 36;
            this.button2.Text = "INVOICE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(1125, 750);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Note : Click this button for Print Bill";
            // 
            // Recervation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 1055);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelcp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelarrive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltotald);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Recervation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recervation";
            this.Load += new System.EventHandler(this.Recervation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltotald;
        private System.Windows.Forms.Label labelarrive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelcp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
    }
}