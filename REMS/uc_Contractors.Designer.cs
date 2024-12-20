
namespace REMS
{
    partial class uc_Contractors
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
            this.pnlUConSearch = new System.Windows.Forms.Panel();
            this.btnUConSearchShow = new System.Windows.Forms.Button();
            this.rb_UConByPhone = new System.Windows.Forms.RadioButton();
            this.rb_UConByName = new System.Windows.Forms.RadioButton();
            this.txtUConSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUConSearch = new System.Windows.Forms.Button();
            this.btnUConViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Contractors = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlUConSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contractors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlUConSearch);
            this.panel1.Controls.Add(this.btnUConSearch);
            this.panel1.Controls.Add(this.btnUConViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // pnlUConSearch
            // 
            this.pnlUConSearch.Controls.Add(this.btnUConSearchShow);
            this.pnlUConSearch.Controls.Add(this.rb_UConByPhone);
            this.pnlUConSearch.Controls.Add(this.rb_UConByName);
            this.pnlUConSearch.Controls.Add(this.txtUConSearch);
            this.pnlUConSearch.Controls.Add(this.label2);
            this.pnlUConSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUConSearch.Location = new System.Drawing.Point(0, 178);
            this.pnlUConSearch.Name = "pnlUConSearch";
            this.pnlUConSearch.Size = new System.Drawing.Size(200, 198);
            this.pnlUConSearch.TabIndex = 8;
            this.pnlUConSearch.Visible = false;
            // 
            // btnUConSearchShow
            // 
            this.btnUConSearchShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUConSearchShow.FlatAppearance.BorderSize = 2;
            this.btnUConSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUConSearchShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUConSearchShow.Location = new System.Drawing.Point(50, 154);
            this.btnUConSearchShow.Name = "btnUConSearchShow";
            this.btnUConSearchShow.Size = new System.Drawing.Size(100, 30);
            this.btnUConSearchShow.TabIndex = 6;
            this.btnUConSearchShow.Text = "SEARCH";
            this.btnUConSearchShow.UseVisualStyleBackColor = true;
            this.btnUConSearchShow.Click += new System.EventHandler(this.btnUConSearchShow_Click);
            // 
            // rb_UConByPhone
            // 
            this.rb_UConByPhone.AutoSize = true;
            this.rb_UConByPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_UConByPhone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rb_UConByPhone.FlatAppearance.BorderSize = 0;
            this.rb_UConByPhone.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rb_UConByPhone.ForeColor = System.Drawing.Color.White;
            this.rb_UConByPhone.Location = new System.Drawing.Point(27, 104);
            this.rb_UConByPhone.Name = "rb_UConByPhone";
            this.rb_UConByPhone.Size = new System.Drawing.Size(113, 19);
            this.rb_UConByPhone.TabIndex = 5;
            this.rb_UConByPhone.TabStop = true;
            this.rb_UConByPhone.Text = "Search By Phone";
            this.rb_UConByPhone.UseVisualStyleBackColor = true;
            this.rb_UConByPhone.CheckedChanged += new System.EventHandler(this.rb_UConByPhone_CheckedChanged);
            // 
            // rb_UConByName
            // 
            this.rb_UConByName.AutoSize = true;
            this.rb_UConByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_UConByName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rb_UConByName.FlatAppearance.BorderSize = 0;
            this.rb_UConByName.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rb_UConByName.ForeColor = System.Drawing.Color.White;
            this.rb_UConByName.Location = new System.Drawing.Point(27, 79);
            this.rb_UConByName.Name = "rb_UConByName";
            this.rb_UConByName.Size = new System.Drawing.Size(111, 19);
            this.rb_UConByName.TabIndex = 4;
            this.rb_UConByName.TabStop = true;
            this.rb_UConByName.Text = "Search By Name";
            this.rb_UConByName.UseVisualStyleBackColor = true;
            this.rb_UConByName.CheckedChanged += new System.EventHandler(this.rb_UConByName_CheckedChanged);
            // 
            // txtUConSearch
            // 
            this.txtUConSearch.Location = new System.Drawing.Point(27, 39);
            this.txtUConSearch.Name = "txtUConSearch";
            this.txtUConSearch.PlaceholderText = "Search";
            this.txtUConSearch.Size = new System.Drawing.Size(150, 23);
            this.txtUConSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter search term";
            // 
            // btnUConSearch
            // 
            this.btnUConSearch.AutoSize = true;
            this.btnUConSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUConSearch.FlatAppearance.BorderSize = 0;
            this.btnUConSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUConSearch.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUConSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUConSearch.Location = new System.Drawing.Point(0, 139);
            this.btnUConSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUConSearch.Name = "btnUConSearch";
            this.btnUConSearch.Size = new System.Drawing.Size(200, 39);
            this.btnUConSearch.TabIndex = 7;
            this.btnUConSearch.Text = "Search Contractor";
            this.btnUConSearch.UseVisualStyleBackColor = true;
            this.btnUConSearch.Click += new System.EventHandler(this.btnUConSearch_Click);
            // 
            // btnUConViewAll
            // 
            this.btnUConViewAll.AutoSize = true;
            this.btnUConViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUConViewAll.FlatAppearance.BorderSize = 0;
            this.btnUConViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUConViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUConViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUConViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUConViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUConViewAll.Name = "btnUConViewAll";
            this.btnUConViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnUConViewAll.TabIndex = 6;
            this.btnUConViewAll.Text = "View All Contractors";
            this.btnUConViewAll.UseVisualStyleBackColor = true;
            this.btnUConViewAll.Click += new System.EventHandler(this.btnUConViewAll_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgv_Contractors);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 563);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contractors";
            // 
            // dgv_Contractors
            // 
            this.dgv_Contractors.AllowUserToAddRows = false;
            this.dgv_Contractors.AllowUserToDeleteRows = false;
            this.dgv_Contractors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Contractors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Contractors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Contractors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Contractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Contractors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Contractors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Contractors.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Contractors.Location = new System.Drawing.Point(30, 99);
            this.dgv_Contractors.Name = "dgv_Contractors";
            this.dgv_Contractors.ReadOnly = true;
            this.dgv_Contractors.RowTemplate.Height = 25;
            this.dgv_Contractors.Size = new System.Drawing.Size(947, 432);
            this.dgv_Contractors.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 2;
            // 
            // uc_Contractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_Contractors";
            this.Size = new System.Drawing.Size(1220, 563);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUConSearch.ResumeLayout(false);
            this.pnlUConSearch.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contractors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUConViewAll;
        private System.Windows.Forms.Button btnUConSearch;
        private System.Windows.Forms.Panel pnlUConSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUConSearch;
        private System.Windows.Forms.RadioButton rb_UConByPhone;
        private System.Windows.Forms.RadioButton rb_UConByName;
        private System.Windows.Forms.Button btnUConSearchShow;
        private System.Windows.Forms.DataGridView dgv_Contractors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}
