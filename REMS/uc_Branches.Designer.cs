
namespace REMS
{
    partial class uc_Branches
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
            this.pnlUBrnFilter = new System.Windows.Forms.Panel();
            this.txtUBrnFilterBranchType = new System.Windows.Forms.TextBox();
            this.txtUBrnFilterCity = new System.Windows.Forms.TextBox();
            this.cBoxUBrnFilterRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUBrnFilterShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUBrnFilter = new System.Windows.Forms.Button();
            this.btnUBrnViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Branches = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlUBrnFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Branches)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlUBrnFilter);
            this.panel1.Controls.Add(this.btnUBrnFilter);
            this.panel1.Controls.Add(this.btnUBrnViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // pnlUBrnFilter
            // 
            this.pnlUBrnFilter.Controls.Add(this.txtUBrnFilterBranchType);
            this.pnlUBrnFilter.Controls.Add(this.txtUBrnFilterCity);
            this.pnlUBrnFilter.Controls.Add(this.cBoxUBrnFilterRegion);
            this.pnlUBrnFilter.Controls.Add(this.label4);
            this.pnlUBrnFilter.Controls.Add(this.label3);
            this.pnlUBrnFilter.Controls.Add(this.btnUBrnFilterShow);
            this.pnlUBrnFilter.Controls.Add(this.label1);
            this.pnlUBrnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUBrnFilter.Location = new System.Drawing.Point(0, 178);
            this.pnlUBrnFilter.Name = "pnlUBrnFilter";
            this.pnlUBrnFilter.Size = new System.Drawing.Size(200, 225);
            this.pnlUBrnFilter.TabIndex = 12;
            this.pnlUBrnFilter.Visible = false;
            // 
            // txtUBrnFilterBranchType
            // 
            this.txtUBrnFilterBranchType.Location = new System.Drawing.Point(27, 147);
            this.txtUBrnFilterBranchType.Name = "txtUBrnFilterBranchType";
            this.txtUBrnFilterBranchType.PlaceholderText = "Branch type";
            this.txtUBrnFilterBranchType.Size = new System.Drawing.Size(150, 23);
            this.txtUBrnFilterBranchType.TabIndex = 11;
            // 
            // txtUBrnFilterCity
            // 
            this.txtUBrnFilterCity.Location = new System.Drawing.Point(27, 92);
            this.txtUBrnFilterCity.Name = "txtUBrnFilterCity";
            this.txtUBrnFilterCity.PlaceholderText = "City name";
            this.txtUBrnFilterCity.Size = new System.Drawing.Size(150, 23);
            this.txtUBrnFilterCity.TabIndex = 10;
            // 
            // cBoxUBrnFilterRegion
            // 
            this.cBoxUBrnFilterRegion.FormattingEnabled = true;
            this.cBoxUBrnFilterRegion.Items.AddRange(new object[] {
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
            this.cBoxUBrnFilterRegion.Location = new System.Drawing.Point(27, 39);
            this.cBoxUBrnFilterRegion.Name = "cBoxUBrnFilterRegion";
            this.cBoxUBrnFilterRegion.Size = new System.Drawing.Size(150, 23);
            this.cBoxUBrnFilterRegion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter a Branch Type";
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
            // btnUBrnFilterShow
            // 
            this.btnUBrnFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUBrnFilterShow.FlatAppearance.BorderSize = 2;
            this.btnUBrnFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUBrnFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUBrnFilterShow.Location = new System.Drawing.Point(51, 192);
            this.btnUBrnFilterShow.Name = "btnUBrnFilterShow";
            this.btnUBrnFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnUBrnFilterShow.TabIndex = 6;
            this.btnUBrnFilterShow.Text = "FILTER";
            this.btnUBrnFilterShow.UseVisualStyleBackColor = true;
            this.btnUBrnFilterShow.Click += new System.EventHandler(this.btnUBrnFilterShow_Click);
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
            // btnUBrnFilter
            // 
            this.btnUBrnFilter.AutoSize = true;
            this.btnUBrnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUBrnFilter.FlatAppearance.BorderSize = 0;
            this.btnUBrnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUBrnFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUBrnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUBrnFilter.Location = new System.Drawing.Point(0, 139);
            this.btnUBrnFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUBrnFilter.Name = "btnUBrnFilter";
            this.btnUBrnFilter.Size = new System.Drawing.Size(200, 39);
            this.btnUBrnFilter.TabIndex = 11;
            this.btnUBrnFilter.Text = "Filter";
            this.btnUBrnFilter.UseVisualStyleBackColor = true;
            this.btnUBrnFilter.Click += new System.EventHandler(this.btnUBrnFilter_Click);
            // 
            // btnUBrnViewAll
            // 
            this.btnUBrnViewAll.AutoSize = true;
            this.btnUBrnViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUBrnViewAll.FlatAppearance.BorderSize = 0;
            this.btnUBrnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUBrnViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUBrnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUBrnViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUBrnViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUBrnViewAll.Name = "btnUBrnViewAll";
            this.btnUBrnViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnUBrnViewAll.TabIndex = 8;
            this.btnUBrnViewAll.Text = "View All Branches";
            this.btnUBrnViewAll.UseVisualStyleBackColor = true;
            this.btnUBrnViewAll.Click += new System.EventHandler(this.btnUBrnViewAll_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Branches);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 560);
            this.panel2.TabIndex = 1;
            // 
            // dgv_Branches
            // 
            this.dgv_Branches.AllowUserToAddRows = false;
            this.dgv_Branches.AllowUserToDeleteRows = false;
            this.dgv_Branches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Branches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Branches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Branches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Branches.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Branches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Branches.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Branches.Location = new System.Drawing.Point(30, 99);
            this.dgv_Branches.Name = "dgv_Branches";
            this.dgv_Branches.ReadOnly = true;
            this.dgv_Branches.RowTemplate.Height = 25;
            this.dgv_Branches.Size = new System.Drawing.Size(947, 432);
            this.dgv_Branches.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Branches";
            // 
            // uc_Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_Branches";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_Branches_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUBrnFilter.ResumeLayout(false);
            this.pnlUBrnFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Branches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUBrnViewAll;
        private System.Windows.Forms.Button btnUBrnFilter;
        private System.Windows.Forms.Panel pnlUBrnFilter;
        private System.Windows.Forms.TextBox txtUBrnFilterCity;
        private System.Windows.Forms.ComboBox cBoxUBrnFilterRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUBrnFilterShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Branches;
        private System.Windows.Forms.TextBox txtUBrnFilterBranchType;
    }
}
