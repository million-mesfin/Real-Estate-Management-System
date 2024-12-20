
namespace REMS
{
    partial class uc_ServiceProviders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUSpViewAll = new System.Windows.Forms.Button();
            this.btnUSpSearch = new System.Windows.Forms.Button();
            this.pnlUSpSearch = new System.Windows.Forms.Panel();
            this.txtUSpSearch = new System.Windows.Forms.TextBox();
            this.btnUSpSearchShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUSpFilter = new System.Windows.Forms.Button();
            this.rb_USpSearchName = new System.Windows.Forms.RadioButton();
            this.rb_USpSearchByPhone = new System.Windows.Forms.RadioButton();
            this.pnlUSpFilter = new System.Windows.Forms.Panel();
            this.txtUSpFilterCity = new System.Windows.Forms.TextBox();
            this.btnUSpFilterShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxUSpFilterRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUSpFilterServiceType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ServiceProviders = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUSpSearch.SuspendLayout();
            this.pnlUSpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ServiceProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlUSpFilter);
            this.panel1.Controls.Add(this.btnUSpFilter);
            this.panel1.Controls.Add(this.pnlUSpSearch);
            this.panel1.Controls.Add(this.btnUSpSearch);
            this.panel1.Controls.Add(this.btnUSpViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_ServiceProviders);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 563);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // btnUSpViewAll
            // 
            this.btnUSpViewAll.AutoSize = true;
            this.btnUSpViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSpViewAll.FlatAppearance.BorderSize = 0;
            this.btnUSpViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSpViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUSpViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSpViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnUSpViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUSpViewAll.Name = "btnUSpViewAll";
            this.btnUSpViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnUSpViewAll.TabIndex = 8;
            this.btnUSpViewAll.Text = "View All";
            this.btnUSpViewAll.UseVisualStyleBackColor = true;
            this.btnUSpViewAll.Click += new System.EventHandler(this.btnUSpViewAll_Click);
            // 
            // btnUSpSearch
            // 
            this.btnUSpSearch.AutoSize = true;
            this.btnUSpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSpSearch.FlatAppearance.BorderSize = 0;
            this.btnUSpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSpSearch.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUSpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSpSearch.Location = new System.Drawing.Point(0, 139);
            this.btnUSpSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUSpSearch.Name = "btnUSpSearch";
            this.btnUSpSearch.Size = new System.Drawing.Size(200, 39);
            this.btnUSpSearch.TabIndex = 9;
            this.btnUSpSearch.Text = "Search";
            this.btnUSpSearch.UseVisualStyleBackColor = true;
            this.btnUSpSearch.Click += new System.EventHandler(this.btnUSpSearch_Click);
            // 
            // pnlUSpSearch
            // 
            this.pnlUSpSearch.Controls.Add(this.rb_USpSearchByPhone);
            this.pnlUSpSearch.Controls.Add(this.rb_USpSearchName);
            this.pnlUSpSearch.Controls.Add(this.txtUSpSearch);
            this.pnlUSpSearch.Controls.Add(this.btnUSpSearchShow);
            this.pnlUSpSearch.Controls.Add(this.label1);
            this.pnlUSpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUSpSearch.Location = new System.Drawing.Point(0, 178);
            this.pnlUSpSearch.Name = "pnlUSpSearch";
            this.pnlUSpSearch.Size = new System.Drawing.Size(200, 178);
            this.pnlUSpSearch.TabIndex = 12;
            this.pnlUSpSearch.Visible = false;
            // 
            // txtUSpSearch
            // 
            this.txtUSpSearch.Location = new System.Drawing.Point(27, 39);
            this.txtUSpSearch.Name = "txtUSpSearch";
            this.txtUSpSearch.PlaceholderText = "Search term";
            this.txtUSpSearch.Size = new System.Drawing.Size(150, 23);
            this.txtUSpSearch.TabIndex = 10;
            // 
            // btnUSpSearchShow
            // 
            this.btnUSpSearchShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUSpSearchShow.FlatAppearance.BorderSize = 2;
            this.btnUSpSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSpSearchShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSpSearchShow.Location = new System.Drawing.Point(52, 140);
            this.btnUSpSearchShow.Name = "btnUSpSearchShow";
            this.btnUSpSearchShow.Size = new System.Drawing.Size(100, 30);
            this.btnUSpSearchShow.TabIndex = 6;
            this.btnUSpSearchShow.Text = "SEARCH";
            this.btnUSpSearchShow.UseVisualStyleBackColor = true;
            this.btnUSpSearchShow.Click += new System.EventHandler(this.btnUSpSearchShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a search term";
            // 
            // btnUSpFilter
            // 
            this.btnUSpFilter.AutoSize = true;
            this.btnUSpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSpFilter.FlatAppearance.BorderSize = 0;
            this.btnUSpFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSpFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUSpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSpFilter.Location = new System.Drawing.Point(0, 356);
            this.btnUSpFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUSpFilter.Name = "btnUSpFilter";
            this.btnUSpFilter.Size = new System.Drawing.Size(200, 39);
            this.btnUSpFilter.TabIndex = 13;
            this.btnUSpFilter.Text = "Filter";
            this.btnUSpFilter.UseVisualStyleBackColor = true;
            this.btnUSpFilter.Click += new System.EventHandler(this.btnUSpFilter_Click);
            // 
            // rb_USpSearchName
            // 
            this.rb_USpSearchName.AutoSize = true;
            this.rb_USpSearchName.ForeColor = System.Drawing.Color.White;
            this.rb_USpSearchName.Location = new System.Drawing.Point(27, 80);
            this.rb_USpSearchName.Name = "rb_USpSearchName";
            this.rb_USpSearchName.Size = new System.Drawing.Size(111, 19);
            this.rb_USpSearchName.TabIndex = 11;
            this.rb_USpSearchName.TabStop = true;
            this.rb_USpSearchName.Text = "Search By Name";
            this.rb_USpSearchName.UseVisualStyleBackColor = true;
            this.rb_USpSearchName.CheckedChanged += new System.EventHandler(this.rb_USpSearchName_CheckedChanged);
            // 
            // rb_USpSearchByPhone
            // 
            this.rb_USpSearchByPhone.AutoSize = true;
            this.rb_USpSearchByPhone.ForeColor = System.Drawing.Color.White;
            this.rb_USpSearchByPhone.Location = new System.Drawing.Point(27, 105);
            this.rb_USpSearchByPhone.Name = "rb_USpSearchByPhone";
            this.rb_USpSearchByPhone.Size = new System.Drawing.Size(113, 19);
            this.rb_USpSearchByPhone.TabIndex = 12;
            this.rb_USpSearchByPhone.TabStop = true;
            this.rb_USpSearchByPhone.Text = "Search By Phone";
            this.rb_USpSearchByPhone.UseVisualStyleBackColor = true;
            this.rb_USpSearchByPhone.CheckedChanged += new System.EventHandler(this.rb_USpSearchByPhone_CheckedChanged);
            // 
            // pnlUSpFilter
            // 
            this.pnlUSpFilter.Controls.Add(this.txtUSpFilterServiceType);
            this.pnlUSpFilter.Controls.Add(this.label4);
            this.pnlUSpFilter.Controls.Add(this.cBoxUSpFilterRegion);
            this.pnlUSpFilter.Controls.Add(this.label3);
            this.pnlUSpFilter.Controls.Add(this.txtUSpFilterCity);
            this.pnlUSpFilter.Controls.Add(this.btnUSpFilterShow);
            this.pnlUSpFilter.Controls.Add(this.label2);
            this.pnlUSpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUSpFilter.Location = new System.Drawing.Point(0, 395);
            this.pnlUSpFilter.Name = "pnlUSpFilter";
            this.pnlUSpFilter.Size = new System.Drawing.Size(200, 242);
            this.pnlUSpFilter.TabIndex = 14;
            this.pnlUSpFilter.Visible = false;
            // 
            // txtUSpFilterCity
            // 
            this.txtUSpFilterCity.Location = new System.Drawing.Point(27, 92);
            this.txtUSpFilterCity.Name = "txtUSpFilterCity";
            this.txtUSpFilterCity.PlaceholderText = "City name";
            this.txtUSpFilterCity.Size = new System.Drawing.Size(150, 23);
            this.txtUSpFilterCity.TabIndex = 10;
            // 
            // btnUSpFilterShow
            // 
            this.btnUSpFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUSpFilterShow.FlatAppearance.BorderSize = 2;
            this.btnUSpFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSpFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUSpFilterShow.Location = new System.Drawing.Point(52, 197);
            this.btnUSpFilterShow.Name = "btnUSpFilterShow";
            this.btnUSpFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnUSpFilterShow.TabIndex = 6;
            this.btnUSpFilterShow.Text = "FILTER";
            this.btnUSpFilterShow.UseVisualStyleBackColor = true;
            this.btnUSpFilterShow.Click += new System.EventHandler(this.btnUSpFilterShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter City Name";
            // 
            // cBoxUSpFilterRegion
            // 
            this.cBoxUSpFilterRegion.FormattingEnabled = true;
            this.cBoxUSpFilterRegion.Items.AddRange(new object[] {
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
            this.cBoxUSpFilterRegion.Location = new System.Drawing.Point(27, 39);
            this.cBoxUSpFilterRegion.Name = "cBoxUSpFilterRegion";
            this.cBoxUSpFilterRegion.Size = new System.Drawing.Size(150, 23);
            this.cBoxUSpFilterRegion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Service Type";
            // 
            // txtUSpFilterServiceType
            // 
            this.txtUSpFilterServiceType.Location = new System.Drawing.Point(27, 152);
            this.txtUSpFilterServiceType.Name = "txtUSpFilterServiceType";
            this.txtUSpFilterServiceType.PlaceholderText = "Service type";
            this.txtUSpFilterServiceType.Size = new System.Drawing.Size(150, 23);
            this.txtUSpFilterServiceType.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Service Providers";
            // 
            // dgv_ServiceProviders
            // 
            this.dgv_ServiceProviders.AllowUserToAddRows = false;
            this.dgv_ServiceProviders.AllowUserToDeleteRows = false;
            this.dgv_ServiceProviders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_ServiceProviders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ServiceProviders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ServiceProviders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ServiceProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ServiceProviders.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ServiceProviders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_ServiceProviders.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ServiceProviders.Location = new System.Drawing.Point(30, 99);
            this.dgv_ServiceProviders.Name = "dgv_ServiceProviders";
            this.dgv_ServiceProviders.ReadOnly = true;
            this.dgv_ServiceProviders.RowTemplate.Height = 25;
            this.dgv_ServiceProviders.Size = new System.Drawing.Size(947, 432);
            this.dgv_ServiceProviders.TabIndex = 9;
            // 
            // uc_ServiceProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_ServiceProviders";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_ServiceProviders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUSpSearch.ResumeLayout(false);
            this.pnlUSpSearch.PerformLayout();
            this.pnlUSpFilter.ResumeLayout(false);
            this.pnlUSpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ServiceProviders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUSpSearch;
        private System.Windows.Forms.Button btnUSpViewAll;
        private System.Windows.Forms.Button btnUSpFilter;
        private System.Windows.Forms.Panel pnlUSpSearch;
        private System.Windows.Forms.TextBox txtUSpSearch;
        private System.Windows.Forms.Button btnUSpSearchShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUSpFilter;
        private System.Windows.Forms.TextBox txtUSpFilterCity;
        private System.Windows.Forms.Button btnUSpFilterShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_USpSearchByPhone;
        private System.Windows.Forms.RadioButton rb_USpSearchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSpFilterServiceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxUSpFilterRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_ServiceProviders;
    }
}
