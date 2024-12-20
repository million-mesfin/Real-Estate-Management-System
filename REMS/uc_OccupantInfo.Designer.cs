
namespace REMS
{
    partial class uc_OccupantInfo
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
            this.pnlUOtiContainer = new System.Windows.Forms.Panel();
            this.dgv_Occupants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUOtiSideNav = new System.Windows.Forms.Panel();
            this.pnlUOtiFilter = new System.Windows.Forms.Panel();
            this.btnUOtiFilterShow = new System.Windows.Forms.Button();
            this.cBoxUOtiFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUOtiFilter = new System.Windows.Forms.Button();
            this.pnlUOtiSearch = new System.Windows.Forms.Panel();
            this.btnUOtiSearchShow = new System.Windows.Forms.Button();
            this.rb_UOtiByPhone = new System.Windows.Forms.RadioButton();
            this.rb_UOtiByName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUOtiSearch = new System.Windows.Forms.TextBox();
            this.btnUOtiSearch = new System.Windows.Forms.Button();
            this.btnUOtiViewAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUOtiContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Occupants)).BeginInit();
            this.pnlUOtiSideNav.SuspendLayout();
            this.pnlUOtiFilter.SuspendLayout();
            this.pnlUOtiSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUOtiContainer
            // 
            this.pnlUOtiContainer.Controls.Add(this.dgv_Occupants);
            this.pnlUOtiContainer.Controls.Add(this.label1);
            this.pnlUOtiContainer.Location = new System.Drawing.Point(206, 0);
            this.pnlUOtiContainer.Name = "pnlUOtiContainer";
            this.pnlUOtiContainer.Size = new System.Drawing.Size(1014, 563);
            this.pnlUOtiContainer.TabIndex = 2;
            // 
            // dgv_Occupants
            // 
            this.dgv_Occupants.AllowUserToAddRows = false;
            this.dgv_Occupants.AllowUserToDeleteRows = false;
            this.dgv_Occupants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Occupants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Occupants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Occupants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Occupants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Occupants.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Occupants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Occupants.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Occupants.Location = new System.Drawing.Point(30, 99);
            this.dgv_Occupants.Name = "dgv_Occupants";
            this.dgv_Occupants.ReadOnly = true;
            this.dgv_Occupants.RowTemplate.Height = 25;
            this.dgv_Occupants.Size = new System.Drawing.Size(947, 432);
            this.dgv_Occupants.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Occupant Information";
            // 
            // pnlUOtiSideNav
            // 
            this.pnlUOtiSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnlUOtiSideNav.Controls.Add(this.pnlUOtiFilter);
            this.pnlUOtiSideNav.Controls.Add(this.btnUOtiFilter);
            this.pnlUOtiSideNav.Controls.Add(this.pnlUOtiSearch);
            this.pnlUOtiSideNav.Controls.Add(this.btnUOtiSearch);
            this.pnlUOtiSideNav.Controls.Add(this.btnUOtiViewAll);
            this.pnlUOtiSideNav.Controls.Add(this.panel1);
            this.pnlUOtiSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUOtiSideNav.Location = new System.Drawing.Point(0, 0);
            this.pnlUOtiSideNav.Name = "pnlUOtiSideNav";
            this.pnlUOtiSideNav.Size = new System.Drawing.Size(200, 563);
            this.pnlUOtiSideNav.TabIndex = 3;
            // 
            // pnlUOtiFilter
            // 
            this.pnlUOtiFilter.AutoSize = true;
            this.pnlUOtiFilter.Controls.Add(this.btnUOtiFilterShow);
            this.pnlUOtiFilter.Controls.Add(this.cBoxUOtiFilter);
            this.pnlUOtiFilter.Controls.Add(this.label3);
            this.pnlUOtiFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUOtiFilter.Location = new System.Drawing.Point(0, 397);
            this.pnlUOtiFilter.Name = "pnlUOtiFilter";
            this.pnlUOtiFilter.Size = new System.Drawing.Size(200, 120);
            this.pnlUOtiFilter.TabIndex = 9;
            this.pnlUOtiFilter.Visible = false;
            // 
            // btnUOtiFilterShow
            // 
            this.btnUOtiFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUOtiFilterShow.FlatAppearance.BorderSize = 2;
            this.btnUOtiFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOtiFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOtiFilterShow.Location = new System.Drawing.Point(47, 87);
            this.btnUOtiFilterShow.Name = "btnUOtiFilterShow";
            this.btnUOtiFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnUOtiFilterShow.TabIndex = 5;
            this.btnUOtiFilterShow.Text = "FILTER";
            this.btnUOtiFilterShow.UseVisualStyleBackColor = true;
            this.btnUOtiFilterShow.Click += new System.EventHandler(this.btnUOtiFilterShow_Click);
            // 
            // cBoxUOtiFilter
            // 
            this.cBoxUOtiFilter.FormattingEnabled = true;
            this.cBoxUOtiFilter.Items.AddRange(new object[] {
            "Rental Shop",
            "Apartment",
            "Split-Level",
            "Villa"});
            this.cBoxUOtiFilter.Location = new System.Drawing.Point(24, 45);
            this.cBoxUOtiFilter.Name = "cBoxUOtiFilter";
            this.cBoxUOtiFilter.Size = new System.Drawing.Size(150, 23);
            this.cBoxUOtiFilter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select a house type";
            // 
            // btnUOtiFilter
            // 
            this.btnUOtiFilter.AutoSize = true;
            this.btnUOtiFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUOtiFilter.FlatAppearance.BorderSize = 0;
            this.btnUOtiFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOtiFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUOtiFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOtiFilter.Location = new System.Drawing.Point(0, 358);
            this.btnUOtiFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUOtiFilter.Name = "btnUOtiFilter";
            this.btnUOtiFilter.Size = new System.Drawing.Size(200, 39);
            this.btnUOtiFilter.TabIndex = 8;
            this.btnUOtiFilter.Text = "Filter";
            this.btnUOtiFilter.UseVisualStyleBackColor = true;
            this.btnUOtiFilter.Click += new System.EventHandler(this.btnUOtiFilter_Click);
            // 
            // pnlUOtiSearch
            // 
            this.pnlUOtiSearch.AutoScroll = true;
            this.pnlUOtiSearch.AutoSize = true;
            this.pnlUOtiSearch.Controls.Add(this.btnUOtiSearchShow);
            this.pnlUOtiSearch.Controls.Add(this.rb_UOtiByPhone);
            this.pnlUOtiSearch.Controls.Add(this.rb_UOtiByName);
            this.pnlUOtiSearch.Controls.Add(this.label2);
            this.pnlUOtiSearch.Controls.Add(this.txtUOtiSearch);
            this.pnlUOtiSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUOtiSearch.Location = new System.Drawing.Point(0, 178);
            this.pnlUOtiSearch.Name = "pnlUOtiSearch";
            this.pnlUOtiSearch.Size = new System.Drawing.Size(200, 180);
            this.pnlUOtiSearch.TabIndex = 6;
            this.pnlUOtiSearch.Visible = false;
            // 
            // btnUOtiSearchShow
            // 
            this.btnUOtiSearchShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUOtiSearchShow.FlatAppearance.BorderSize = 2;
            this.btnUOtiSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOtiSearchShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOtiSearchShow.Location = new System.Drawing.Point(47, 147);
            this.btnUOtiSearchShow.Name = "btnUOtiSearchShow";
            this.btnUOtiSearchShow.Size = new System.Drawing.Size(100, 30);
            this.btnUOtiSearchShow.TabIndex = 4;
            this.btnUOtiSearchShow.Text = "SEARCH";
            this.btnUOtiSearchShow.UseVisualStyleBackColor = true;
            this.btnUOtiSearchShow.Click += new System.EventHandler(this.btnUOtiSearchShow_Click);
            // 
            // rb_UOtiByPhone
            // 
            this.rb_UOtiByPhone.AutoSize = true;
            this.rb_UOtiByPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_UOtiByPhone.ForeColor = System.Drawing.Color.White;
            this.rb_UOtiByPhone.Location = new System.Drawing.Point(24, 108);
            this.rb_UOtiByPhone.Name = "rb_UOtiByPhone";
            this.rb_UOtiByPhone.Size = new System.Drawing.Size(113, 19);
            this.rb_UOtiByPhone.TabIndex = 3;
            this.rb_UOtiByPhone.TabStop = true;
            this.rb_UOtiByPhone.Text = "Search By Phone";
            this.rb_UOtiByPhone.UseVisualStyleBackColor = true;
            this.rb_UOtiByPhone.CheckedChanged += new System.EventHandler(this.rb_UOtiByPhone_CheckedChanged);
            // 
            // rb_UOtiByName
            // 
            this.rb_UOtiByName.AutoSize = true;
            this.rb_UOtiByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_UOtiByName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rb_UOtiByName.FlatAppearance.BorderSize = 0;
            this.rb_UOtiByName.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rb_UOtiByName.ForeColor = System.Drawing.Color.White;
            this.rb_UOtiByName.Location = new System.Drawing.Point(24, 83);
            this.rb_UOtiByName.Name = "rb_UOtiByName";
            this.rb_UOtiByName.Size = new System.Drawing.Size(111, 19);
            this.rb_UOtiByName.TabIndex = 2;
            this.rb_UOtiByName.TabStop = true;
            this.rb_UOtiByName.Text = "Search By Name";
            this.rb_UOtiByName.UseVisualStyleBackColor = true;
            this.rb_UOtiByName.CheckedChanged += new System.EventHandler(this.rb_UOtiByName_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter search term";
            // 
            // txtUOtiSearch
            // 
            this.txtUOtiSearch.Location = new System.Drawing.Point(24, 39);
            this.txtUOtiSearch.Name = "txtUOtiSearch";
            this.txtUOtiSearch.PlaceholderText = "Search";
            this.txtUOtiSearch.Size = new System.Drawing.Size(150, 23);
            this.txtUOtiSearch.TabIndex = 0;
            // 
            // btnUOtiSearch
            // 
            this.btnUOtiSearch.AutoSize = true;
            this.btnUOtiSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUOtiSearch.FlatAppearance.BorderSize = 0;
            this.btnUOtiSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOtiSearch.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUOtiSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOtiSearch.Location = new System.Drawing.Point(0, 139);
            this.btnUOtiSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUOtiSearch.Name = "btnUOtiSearch";
            this.btnUOtiSearch.Size = new System.Drawing.Size(200, 39);
            this.btnUOtiSearch.TabIndex = 5;
            this.btnUOtiSearch.Text = "Search Occupant";
            this.btnUOtiSearch.UseVisualStyleBackColor = true;
            this.btnUOtiSearch.Click += new System.EventHandler(this.btnUOtiSearch_Click);
            // 
            // btnUOtiViewAll
            // 
            this.btnUOtiViewAll.AutoSize = true;
            this.btnUOtiViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUOtiViewAll.FlatAppearance.BorderSize = 0;
            this.btnUOtiViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOtiViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUOtiViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUOtiViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUOtiViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUOtiViewAll.Name = "btnUOtiViewAll";
            this.btnUOtiViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnUOtiViewAll.TabIndex = 4;
            this.btnUOtiViewAll.Text = "View All Occupants";
            this.btnUOtiViewAll.UseVisualStyleBackColor = true;
            this.btnUOtiViewAll.Click += new System.EventHandler(this.btnUOtiViewAll_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // uc_OccupantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlUOtiSideNav);
            this.Controls.Add(this.pnlUOtiContainer);
            this.Name = "uc_OccupantInfo";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_OccupantInfo_Load);
            this.pnlUOtiContainer.ResumeLayout(false);
            this.pnlUOtiContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Occupants)).EndInit();
            this.pnlUOtiSideNav.ResumeLayout(false);
            this.pnlUOtiSideNav.PerformLayout();
            this.pnlUOtiFilter.ResumeLayout(false);
            this.pnlUOtiFilter.PerformLayout();
            this.pnlUOtiSearch.ResumeLayout(false);
            this.pnlUOtiSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUOtiContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Occupants;
        private System.Windows.Forms.Panel pnlUOtiSideNav;
        private System.Windows.Forms.Panel pnlUOtiFilter;
        private System.Windows.Forms.Button btnUOtiFilterShow;
        private System.Windows.Forms.ComboBox cBoxUOtiFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUOtiFilter;
        private System.Windows.Forms.Panel pnlUOtiSearch;
        private System.Windows.Forms.Button btnUOtiSearchShow;
        private System.Windows.Forms.RadioButton rb_UOtiByPhone;
        private System.Windows.Forms.RadioButton rb_UOtiByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUOtiSearch;
        private System.Windows.Forms.Button btnUOtiSearch;
        private System.Windows.Forms.Button btnUOtiViewAll;
        private System.Windows.Forms.Panel panel1;
    }
}
