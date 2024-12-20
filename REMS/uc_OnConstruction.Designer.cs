
namespace REMS
{
    partial class uc_OnConstruction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUOcoFilter = new System.Windows.Forms.Panel();
            this.cBoxUOcoFilterHouse = new System.Windows.Forms.ComboBox();
            this.txtUOcoFilterCity = new System.Windows.Forms.TextBox();
            this.cBoxUOcoFilterRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUOcoFilterShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUOcoFilter = new System.Windows.Forms.Button();
            this.btnUOcoViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_OnConstruction = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlUOcoFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnConstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlUOcoFilter);
            this.panel1.Controls.Add(this.btnUOcoFilter);
            this.panel1.Controls.Add(this.btnUOcoViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // pnlUOcoFilter
            // 
            this.pnlUOcoFilter.Controls.Add(this.cBoxUOcoFilterHouse);
            this.pnlUOcoFilter.Controls.Add(this.txtUOcoFilterCity);
            this.pnlUOcoFilter.Controls.Add(this.cBoxUOcoFilterRegion);
            this.pnlUOcoFilter.Controls.Add(this.label4);
            this.pnlUOcoFilter.Controls.Add(this.label3);
            this.pnlUOcoFilter.Controls.Add(this.btnUOcoFilterShow);
            this.pnlUOcoFilter.Controls.Add(this.label1);
            this.pnlUOcoFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUOcoFilter.Location = new System.Drawing.Point(0, 178);
            this.pnlUOcoFilter.Name = "pnlUOcoFilter";
            this.pnlUOcoFilter.Size = new System.Drawing.Size(200, 225);
            this.pnlUOcoFilter.TabIndex = 11;
            this.pnlUOcoFilter.Visible = false;
            // 
            // cBoxUOcoFilterHouse
            // 
            this.cBoxUOcoFilterHouse.FormattingEnabled = true;
            this.cBoxUOcoFilterHouse.Items.AddRange(new object[] {
            "Rental Shop",
            "Apartment",
            "Split-Level",
            "Villa"});
            this.cBoxUOcoFilterHouse.Location = new System.Drawing.Point(27, 147);
            this.cBoxUOcoFilterHouse.Name = "cBoxUOcoFilterHouse";
            this.cBoxUOcoFilterHouse.Size = new System.Drawing.Size(150, 23);
            this.cBoxUOcoFilterHouse.TabIndex = 11;
            // 
            // txtUOcoFilterCity
            // 
            this.txtUOcoFilterCity.Location = new System.Drawing.Point(27, 92);
            this.txtUOcoFilterCity.Name = "txtUOcoFilterCity";
            this.txtUOcoFilterCity.PlaceholderText = "City name";
            this.txtUOcoFilterCity.Size = new System.Drawing.Size(150, 23);
            this.txtUOcoFilterCity.TabIndex = 10;
            // 
            // cBoxUOcoFilterRegion
            // 
            this.cBoxUOcoFilterRegion.FormattingEnabled = true;
            this.cBoxUOcoFilterRegion.Items.AddRange(new object[] {
            "Addis Ababa",
            "Afar",
            "Amhara",
            "Benishangul-Gumuz",
            "Gambela",
            "Harari",
            "Oromia",
            "Sidama",
            "SNNP",
            "Tigray"});
            this.cBoxUOcoFilterRegion.Location = new System.Drawing.Point(27, 39);
            this.cBoxUOcoFilterRegion.Name = "cBoxUOcoFilterRegion";
            this.cBoxUOcoFilterRegion.Size = new System.Drawing.Size(150, 23);
            this.cBoxUOcoFilterRegion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select House Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter City Name";
            // 
            // btnUOcoFilterShow
            // 
            this.btnUOcoFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUOcoFilterShow.FlatAppearance.BorderSize = 2;
            this.btnUOcoFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOcoFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOcoFilterShow.Location = new System.Drawing.Point(51, 192);
            this.btnUOcoFilterShow.Name = "btnUOcoFilterShow";
            this.btnUOcoFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnUOcoFilterShow.TabIndex = 6;
            this.btnUOcoFilterShow.Text = "FILTER";
            this.btnUOcoFilterShow.UseVisualStyleBackColor = true;
            this.btnUOcoFilterShow.Click += new System.EventHandler(this.btnUOcoFilterShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Region";
            // 
            // btnUOcoFilter
            // 
            this.btnUOcoFilter.AutoSize = true;
            this.btnUOcoFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUOcoFilter.FlatAppearance.BorderSize = 0;
            this.btnUOcoFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOcoFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUOcoFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOcoFilter.Location = new System.Drawing.Point(0, 139);
            this.btnUOcoFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUOcoFilter.Name = "btnUOcoFilter";
            this.btnUOcoFilter.Size = new System.Drawing.Size(200, 39);
            this.btnUOcoFilter.TabIndex = 10;
            this.btnUOcoFilter.Text = "Filter";
            this.btnUOcoFilter.UseVisualStyleBackColor = true;
            this.btnUOcoFilter.Click += new System.EventHandler(this.btnUOcoFilter_Click);
            // 
            // btnUOcoViewAll
            // 
            this.btnUOcoViewAll.AutoSize = true;
            this.btnUOcoViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUOcoViewAll.FlatAppearance.BorderSize = 0;
            this.btnUOcoViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOcoViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUOcoViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOcoViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUOcoViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUOcoViewAll.Name = "btnUOcoViewAll";
            this.btnUOcoViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnUOcoViewAll.TabIndex = 7;
            this.btnUOcoViewAll.Text = "View All";
            this.btnUOcoViewAll.UseVisualStyleBackColor = true;
            this.btnUOcoViewAll.Click += new System.EventHandler(this.btnUOcoViewAll_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_OnConstruction);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 563);
            this.panel2.TabIndex = 1;
            // 
            // dgv_OnConstruction
            // 
            this.dgv_OnConstruction.AllowUserToAddRows = false;
            this.dgv_OnConstruction.AllowUserToDeleteRows = false;
            this.dgv_OnConstruction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_OnConstruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_OnConstruction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OnConstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_OnConstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_OnConstruction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_OnConstruction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_OnConstruction.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_OnConstruction.Location = new System.Drawing.Point(30, 99);
            this.dgv_OnConstruction.Name = "dgv_OnConstruction";
            this.dgv_OnConstruction.ReadOnly = true;
            this.dgv_OnConstruction.RowTemplate.Height = 25;
            this.dgv_OnConstruction.Size = new System.Drawing.Size(947, 432);
            this.dgv_OnConstruction.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "On Construction";
            // 
            // uc_OnConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_OnConstruction";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_OnConstruction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUOcoFilter.ResumeLayout(false);
            this.pnlUOcoFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnConstruction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUOcoViewAll;
        private System.Windows.Forms.Panel pnlUOcoFilter;
        private System.Windows.Forms.Button btnUOcoFilterShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUOcoFilter;
        private System.Windows.Forms.TextBox txtUOcoFilterCity;
        private System.Windows.Forms.ComboBox cBoxUOcoFilterRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxUOcoFilterHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_OnConstruction;
    }
}
