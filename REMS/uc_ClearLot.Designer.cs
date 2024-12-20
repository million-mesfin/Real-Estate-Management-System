
namespace REMS
{
    partial class uc_ClearLot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUCplFilter = new System.Windows.Forms.Panel();
            this.txtUCplFilterCity = new System.Windows.Forms.TextBox();
            this.cBoxUCplFilterPermit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUCplFilterShow = new System.Windows.Forms.Button();
            this.cBoxUCplFilterRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUCplFilter = new System.Windows.Forms.Button();
            this.btnUCplViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ClearPlot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlUCplFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClearPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlUCplFilter);
            this.panel1.Controls.Add(this.btnUCplFilter);
            this.panel1.Controls.Add(this.btnUCplViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // pnlUCplFilter
            // 
            this.pnlUCplFilter.AutoSize = true;
            this.pnlUCplFilter.Controls.Add(this.txtUCplFilterCity);
            this.pnlUCplFilter.Controls.Add(this.cBoxUCplFilterPermit);
            this.pnlUCplFilter.Controls.Add(this.label4);
            this.pnlUCplFilter.Controls.Add(this.label2);
            this.pnlUCplFilter.Controls.Add(this.btnUCplFilterShow);
            this.pnlUCplFilter.Controls.Add(this.cBoxUCplFilterRegion);
            this.pnlUCplFilter.Controls.Add(this.label3);
            this.pnlUCplFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUCplFilter.Location = new System.Drawing.Point(0, 178);
            this.pnlUCplFilter.Name = "pnlUCplFilter";
            this.pnlUCplFilter.Size = new System.Drawing.Size(200, 221);
            this.pnlUCplFilter.TabIndex = 10;
            this.pnlUCplFilter.Visible = false;
            // 
            // txtUCplFilterCity
            // 
            this.txtUCplFilterCity.Location = new System.Drawing.Point(24, 93);
            this.txtUCplFilterCity.Name = "txtUCplFilterCity";
            this.txtUCplFilterCity.PlaceholderText = "Enter city name";
            this.txtUCplFilterCity.Size = new System.Drawing.Size(149, 23);
            this.txtUCplFilterCity.TabIndex = 10;
            // 
            // cBoxUCplFilterPermit
            // 
            this.cBoxUCplFilterPermit.FormattingEnabled = true;
            this.cBoxUCplFilterPermit.Items.AddRange(new object[] {
            "Active",
            "Pending",
            "On Hold"});
            this.cBoxUCplFilterPermit.Location = new System.Drawing.Point(24, 146);
            this.cBoxUCplFilterPermit.Name = "cBoxUCplFilterPermit";
            this.cBoxUCplFilterPermit.Size = new System.Drawing.Size(150, 23);
            this.cBoxUCplFilterPermit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select a Permit Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select a City";
            // 
            // btnUCplFilterShow
            // 
            this.btnUCplFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUCplFilterShow.FlatAppearance.BorderSize = 2;
            this.btnUCplFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCplFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUCplFilterShow.Location = new System.Drawing.Point(50, 188);
            this.btnUCplFilterShow.Name = "btnUCplFilterShow";
            this.btnUCplFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnUCplFilterShow.TabIndex = 5;
            this.btnUCplFilterShow.Text = "FILTER";
            this.btnUCplFilterShow.UseVisualStyleBackColor = true;
            this.btnUCplFilterShow.Click += new System.EventHandler(this.btnUCplFilterShow_Click);
            // 
            // cBoxUCplFilterRegion
            // 
            this.cBoxUCplFilterRegion.FormattingEnabled = true;
            this.cBoxUCplFilterRegion.Items.AddRange(new object[] {
            "Addis Abeba",
            "Afar",
            "Amhara",
            "Benishangul-Gumuz",
            "Gambela",
            "Harari",
            "Oromia",
            "Sidama",
            "SNNP",
            "Tigray"});
            this.cBoxUCplFilterRegion.Location = new System.Drawing.Point(24, 36);
            this.cBoxUCplFilterRegion.Name = "cBoxUCplFilterRegion";
            this.cBoxUCplFilterRegion.Size = new System.Drawing.Size(150, 23);
            this.cBoxUCplFilterRegion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select a Region";
            // 
            // btnUCplFilter
            // 
            this.btnUCplFilter.AutoSize = true;
            this.btnUCplFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUCplFilter.FlatAppearance.BorderSize = 0;
            this.btnUCplFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCplFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUCplFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUCplFilter.Location = new System.Drawing.Point(0, 139);
            this.btnUCplFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUCplFilter.Name = "btnUCplFilter";
            this.btnUCplFilter.Size = new System.Drawing.Size(200, 39);
            this.btnUCplFilter.TabIndex = 9;
            this.btnUCplFilter.Text = "Filter";
            this.btnUCplFilter.UseVisualStyleBackColor = true;
            this.btnUCplFilter.Click += new System.EventHandler(this.btnUCplFilter_Click);
            // 
            // btnUCplViewAll
            // 
            this.btnUCplViewAll.AutoSize = true;
            this.btnUCplViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUCplViewAll.FlatAppearance.BorderSize = 0;
            this.btnUCplViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCplViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUCplViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUCplViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUCplViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUCplViewAll.Name = "btnUCplViewAll";
            this.btnUCplViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnUCplViewAll.TabIndex = 5;
            this.btnUCplViewAll.Text = "View All Clear Lots";
            this.btnUCplViewAll.UseVisualStyleBackColor = true;
            this.btnUCplViewAll.Click += new System.EventHandler(this.btnUCplViewAll_Click);
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
            this.panel2.Controls.Add(this.dgv_ClearPlot);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 563);
            this.panel2.TabIndex = 1;
            // 
            // dgv_ClearPlot
            // 
            this.dgv_ClearPlot.AllowUserToAddRows = false;
            this.dgv_ClearPlot.AllowUserToDeleteRows = false;
            this.dgv_ClearPlot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_ClearPlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ClearPlot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClearPlot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ClearPlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ClearPlot.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ClearPlot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_ClearPlot.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ClearPlot.Location = new System.Drawing.Point(30, 99);
            this.dgv_ClearPlot.Name = "dgv_ClearPlot";
            this.dgv_ClearPlot.ReadOnly = true;
            this.dgv_ClearPlot.RowTemplate.Height = 25;
            this.dgv_ClearPlot.Size = new System.Drawing.Size(947, 432);
            this.dgv_ClearPlot.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clear Lots";
            // 
            // uc_ClearLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_ClearLot";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_ClearLot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUCplFilter.ResumeLayout(false);
            this.pnlUCplFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClearPlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUCplViewAll;
        private System.Windows.Forms.Button btnUCplFilter;
        private System.Windows.Forms.Panel pnlUCplFilter;
        private System.Windows.Forms.Button btnUCplFilterShow;
        private System.Windows.Forms.ComboBox cBoxUCplFilterRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUCplFilterCity;
        private System.Windows.Forms.ComboBox cBoxUCplFilterPermit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ClearPlot;
    }
}
