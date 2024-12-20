
namespace REMS
{
    partial class SoldHouses
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
            this.pnlUSldFilter = new System.Windows.Forms.Panel();
            this.btnUSldFilterShow = new System.Windows.Forms.Button();
            this.btnUSldFilterPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cBoxUSldFilterHouseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUSldFilter = new System.Windows.Forms.Button();
            this.pnlUSldSearch = new System.Windows.Forms.Panel();
            this.btnUSldSearchShow = new System.Windows.Forms.Button();
            this.rb_USldSearchByOpt = new System.Windows.Forms.RadioButton();
            this.rb_USldSearchByHouse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUSldSearch = new System.Windows.Forms.TextBox();
            this.btnUSldSearch = new System.Windows.Forms.Button();
            this.btnUSldViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_SoldHouses = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlUSldFilter.SuspendLayout();
            this.pnlUSldSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoldHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlUSldFilter);
            this.panel1.Controls.Add(this.btnUSldFilter);
            this.panel1.Controls.Add(this.pnlUSldSearch);
            this.panel1.Controls.Add(this.btnUSldSearch);
            this.panel1.Controls.Add(this.btnUSldViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // pnlUSldFilter
            // 
            this.pnlUSldFilter.Controls.Add(this.btnUSldFilterShow);
            this.pnlUSldFilter.Controls.Add(this.btnUSldFilterPaymentStatus);
            this.pnlUSldFilter.Controls.Add(this.cBoxUSldFilterHouseType);
            this.pnlUSldFilter.Controls.Add(this.label3);
            this.pnlUSldFilter.Controls.Add(this.label2);
            this.pnlUSldFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUSldFilter.Location = new System.Drawing.Point(0, 385);
            this.pnlUSldFilter.Name = "pnlUSldFilter";
            this.pnlUSldFilter.Size = new System.Drawing.Size(200, 145);
            this.pnlUSldFilter.TabIndex = 5;
            this.pnlUSldFilter.Visible = false;
            // 
            // btnUSldFilterShow
            // 
            this.btnUSldFilterShow.FlatAppearance.BorderSize = 2;
            this.btnUSldFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSldFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSldFilterShow.Location = new System.Drawing.Point(58, 112);
            this.btnUSldFilterShow.Name = "btnUSldFilterShow";
            this.btnUSldFilterShow.Size = new System.Drawing.Size(75, 30);
            this.btnUSldFilterShow.TabIndex = 5;
            this.btnUSldFilterShow.Text = "FILTER";
            this.btnUSldFilterShow.UseVisualStyleBackColor = true;
            this.btnUSldFilterShow.Click += new System.EventHandler(this.btnUSldFilterShow_Click);
            // 
            // btnUSldFilterPaymentStatus
            // 
            this.btnUSldFilterPaymentStatus.FormattingEnabled = true;
            this.btnUSldFilterPaymentStatus.Items.AddRange(new object[] {
            "Completed",
            "Active Long Term",
            "Active Short Term"});
            this.btnUSldFilterPaymentStatus.Location = new System.Drawing.Point(23, 81);
            this.btnUSldFilterPaymentStatus.Name = "btnUSldFilterPaymentStatus";
            this.btnUSldFilterPaymentStatus.Size = new System.Drawing.Size(150, 23);
            this.btnUSldFilterPaymentStatus.TabIndex = 3;
            // 
            // cBoxUSldFilterHouseType
            // 
            this.cBoxUSldFilterHouseType.FormattingEnabled = true;
            this.cBoxUSldFilterHouseType.Items.AddRange(new object[] {
            "Rental Shop",
            "Apartment",
            "Split_Level"});
            this.cBoxUSldFilterHouseType.Location = new System.Drawing.Point(23, 28);
            this.cBoxUSldFilterHouseType.Name = "cBoxUSldFilterHouseType";
            this.cBoxUSldFilterHouseType.Size = new System.Drawing.Size(150, 23);
            this.cBoxUSldFilterHouseType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select a payment status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a house type";
            // 
            // btnUSldFilter
            // 
            this.btnUSldFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSldFilter.FlatAppearance.BorderSize = 0;
            this.btnUSldFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSldFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUSldFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSldFilter.Location = new System.Drawing.Point(0, 350);
            this.btnUSldFilter.Name = "btnUSldFilter";
            this.btnUSldFilter.Size = new System.Drawing.Size(200, 35);
            this.btnUSldFilter.TabIndex = 4;
            this.btnUSldFilter.Text = "Filter";
            this.btnUSldFilter.UseVisualStyleBackColor = true;
            this.btnUSldFilter.Click += new System.EventHandler(this.btnUSldFilter_Click);
            // 
            // pnlUSldSearch
            // 
            this.pnlUSldSearch.Controls.Add(this.btnUSldSearchShow);
            this.pnlUSldSearch.Controls.Add(this.rb_USldSearchByOpt);
            this.pnlUSldSearch.Controls.Add(this.rb_USldSearchByHouse);
            this.pnlUSldSearch.Controls.Add(this.label1);
            this.pnlUSldSearch.Controls.Add(this.txtUSldSearch);
            this.pnlUSldSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUSldSearch.Location = new System.Drawing.Point(0, 170);
            this.pnlUSldSearch.Name = "pnlUSldSearch";
            this.pnlUSldSearch.Size = new System.Drawing.Size(200, 180);
            this.pnlUSldSearch.TabIndex = 3;
            this.pnlUSldSearch.Visible = false;
            // 
            // btnUSldSearchShow
            // 
            this.btnUSldSearchShow.FlatAppearance.BorderSize = 2;
            this.btnUSldSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSldSearchShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSldSearchShow.Location = new System.Drawing.Point(58, 135);
            this.btnUSldSearchShow.Name = "btnUSldSearchShow";
            this.btnUSldSearchShow.Size = new System.Drawing.Size(75, 30);
            this.btnUSldSearchShow.TabIndex = 4;
            this.btnUSldSearchShow.Text = "SEARCH";
            this.btnUSldSearchShow.UseVisualStyleBackColor = true;
            this.btnUSldSearchShow.Click += new System.EventHandler(this.btnUSldSearchShow_Click);
            // 
            // rb_USldSearchByOpt
            // 
            this.rb_USldSearchByOpt.AutoSize = true;
            this.rb_USldSearchByOpt.ForeColor = System.Drawing.Color.White;
            this.rb_USldSearchByOpt.Location = new System.Drawing.Point(23, 110);
            this.rb_USldSearchByOpt.Name = "rb_USldSearchByOpt";
            this.rb_USldSearchByOpt.Size = new System.Drawing.Size(145, 19);
            this.rb_USldSearchByOpt.TabIndex = 3;
            this.rb_USldSearchByOpt.TabStop = true;
            this.rb_USldSearchByOpt.Text = "Search By Occupant ID";
            this.rb_USldSearchByOpt.UseVisualStyleBackColor = true;
            this.rb_USldSearchByOpt.CheckedChanged += new System.EventHandler(this.rb_USldSearchByOpt_CheckedChanged);
            // 
            // rb_USldSearchByHouse
            // 
            this.rb_USldSearchByHouse.AutoSize = true;
            this.rb_USldSearchByHouse.ForeColor = System.Drawing.Color.White;
            this.rb_USldSearchByHouse.Location = new System.Drawing.Point(23, 85);
            this.rb_USldSearchByHouse.Name = "rb_USldSearchByHouse";
            this.rb_USldSearchByHouse.Size = new System.Drawing.Size(127, 19);
            this.rb_USldSearchByHouse.TabIndex = 2;
            this.rb_USldSearchByHouse.TabStop = true;
            this.rb_USldSearchByHouse.Text = "Search By House ID";
            this.rb_USldSearchByHouse.UseVisualStyleBackColor = true;
            this.rb_USldSearchByHouse.CheckedChanged += new System.EventHandler(this.rb_USldSearchByHouse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter search term";
            // 
            // txtUSldSearch
            // 
            this.txtUSldSearch.Location = new System.Drawing.Point(23, 46);
            this.txtUSldSearch.Name = "txtUSldSearch";
            this.txtUSldSearch.PlaceholderText = "Enter search key";
            this.txtUSldSearch.Size = new System.Drawing.Size(150, 23);
            this.txtUSldSearch.TabIndex = 0;
            // 
            // btnUSldSearch
            // 
            this.btnUSldSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSldSearch.FlatAppearance.BorderSize = 0;
            this.btnUSldSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSldSearch.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUSldSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSldSearch.Location = new System.Drawing.Point(0, 135);
            this.btnUSldSearch.Name = "btnUSldSearch";
            this.btnUSldSearch.Size = new System.Drawing.Size(200, 35);
            this.btnUSldSearch.TabIndex = 2;
            this.btnUSldSearch.Text = "Search";
            this.btnUSldSearch.UseVisualStyleBackColor = true;
            this.btnUSldSearch.Click += new System.EventHandler(this.btnUSldSearch_Click);
            // 
            // btnUSldViewAll
            // 
            this.btnUSldViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSldViewAll.FlatAppearance.BorderSize = 0;
            this.btnUSldViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSldViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUSldViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSldViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUSldViewAll.Name = "btnUSldViewAll";
            this.btnUSldViewAll.Size = new System.Drawing.Size(200, 35);
            this.btnUSldViewAll.TabIndex = 1;
            this.btnUSldViewAll.Text = "View All Occupied";
            this.btnUSldViewAll.UseVisualStyleBackColor = true;
            this.btnUSldViewAll.Click += new System.EventHandler(this.btnUSldViewAll_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_SoldHouses);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 560);
            this.panel2.TabIndex = 1;
            // 
            // dgv_SoldHouses
            // 
            this.dgv_SoldHouses.AllowUserToAddRows = false;
            this.dgv_SoldHouses.AllowUserToDeleteRows = false;
            this.dgv_SoldHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_SoldHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SoldHouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SoldHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SoldHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SoldHouses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SoldHouses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_SoldHouses.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_SoldHouses.Location = new System.Drawing.Point(30, 99);
            this.dgv_SoldHouses.Name = "dgv_SoldHouses";
            this.dgv_SoldHouses.ReadOnly = true;
            this.dgv_SoldHouses.RowTemplate.Height = 25;
            this.dgv_SoldHouses.Size = new System.Drawing.Size(947, 432);
            this.dgv_SoldHouses.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Occupied Houses";
            // 
            // SoldHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SoldHouses";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.SoldHouses_Load);
            this.panel1.ResumeLayout(false);
            this.pnlUSldFilter.ResumeLayout(false);
            this.pnlUSldFilter.PerformLayout();
            this.pnlUSldSearch.ResumeLayout(false);
            this.pnlUSldSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoldHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUSldSearch;
        private System.Windows.Forms.Button btnUSldViewAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlUSldFilter;
        private System.Windows.Forms.Button btnUSldFilterShow;
        private System.Windows.Forms.ComboBox btnUSldFilterPaymentStatus;
        private System.Windows.Forms.ComboBox cBoxUSldFilterHouseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUSldFilter;
        private System.Windows.Forms.Panel pnlUSldSearch;
        private System.Windows.Forms.Button btnUSldSearchShow;
        private System.Windows.Forms.RadioButton rb_USldSearchByOpt;
        private System.Windows.Forms.RadioButton rb_USldSearchByHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUSldSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_SoldHouses;
    }
}
