
namespace REMS
{
    partial class uc_OccupantAdmin
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
            this.pnlAOtiSideNav = new System.Windows.Forms.Panel();
            this.pnlAOtiModify = new System.Windows.Forms.Panel();
            this.btnAOtiDeleteInfo = new System.Windows.Forms.Button();
            this.btnAOtiEditInfo = new System.Windows.Forms.Button();
            this.btnAOtiAddOccupant = new System.Windows.Forms.Button();
            this.btnAOtiModify = new System.Windows.Forms.Button();
            this.pnlAOtiFilter = new System.Windows.Forms.Panel();
            this.btnAOtiFilterShow = new System.Windows.Forms.Button();
            this.cBoxAOtiFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAOtiFilter = new System.Windows.Forms.Button();
            this.pnlAOtiSearch = new System.Windows.Forms.Panel();
            this.btnAOtiSearchShow = new System.Windows.Forms.Button();
            this.rb_AOtiByPhone = new System.Windows.Forms.RadioButton();
            this.rb_AOtiByName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAOtiSearch = new System.Windows.Forms.TextBox();
            this.btnAOtiSearch = new System.Windows.Forms.Button();
            this.btnAOtiViewAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAOtiContainer = new System.Windows.Forms.Panel();
            this.dgv_Occupants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAOtiSideNav.SuspendLayout();
            this.pnlAOtiModify.SuspendLayout();
            this.pnlAOtiFilter.SuspendLayout();
            this.pnlAOtiSearch.SuspendLayout();
            this.pnlAOtiContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Occupants)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAOtiSideNav
            // 
            this.pnlAOtiSideNav.AutoScroll = true;
            this.pnlAOtiSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnlAOtiSideNav.Controls.Add(this.pnlAOtiModify);
            this.pnlAOtiSideNav.Controls.Add(this.btnAOtiModify);
            this.pnlAOtiSideNav.Controls.Add(this.pnlAOtiFilter);
            this.pnlAOtiSideNav.Controls.Add(this.btnAOtiFilter);
            this.pnlAOtiSideNav.Controls.Add(this.pnlAOtiSearch);
            this.pnlAOtiSideNav.Controls.Add(this.btnAOtiSearch);
            this.pnlAOtiSideNav.Controls.Add(this.btnAOtiViewAll);
            this.pnlAOtiSideNav.Controls.Add(this.panel1);
            this.pnlAOtiSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAOtiSideNav.Location = new System.Drawing.Point(0, 0);
            this.pnlAOtiSideNav.Name = "pnlAOtiSideNav";
            this.pnlAOtiSideNav.Size = new System.Drawing.Size(200, 564);
            this.pnlAOtiSideNav.TabIndex = 4;
            // 
            // pnlAOtiModify
            // 
            this.pnlAOtiModify.Controls.Add(this.btnAOtiDeleteInfo);
            this.pnlAOtiModify.Controls.Add(this.btnAOtiEditInfo);
            this.pnlAOtiModify.Controls.Add(this.btnAOtiAddOccupant);
            this.pnlAOtiModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAOtiModify.Location = new System.Drawing.Point(0, 556);
            this.pnlAOtiModify.Name = "pnlAOtiModify";
            this.pnlAOtiModify.Size = new System.Drawing.Size(183, 106);
            this.pnlAOtiModify.TabIndex = 5;
            this.pnlAOtiModify.Visible = false;
            // 
            // btnAOtiDeleteInfo
            // 
            this.btnAOtiDeleteInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiDeleteInfo.FlatAppearance.BorderSize = 0;
            this.btnAOtiDeleteInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiDeleteInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiDeleteInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiDeleteInfo.Location = new System.Drawing.Point(0, 70);
            this.btnAOtiDeleteInfo.Name = "btnAOtiDeleteInfo";
            this.btnAOtiDeleteInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAOtiDeleteInfo.Size = new System.Drawing.Size(183, 35);
            this.btnAOtiDeleteInfo.TabIndex = 3;
            this.btnAOtiDeleteInfo.Text = "Delete Occupant";
            this.btnAOtiDeleteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAOtiDeleteInfo.UseVisualStyleBackColor = true;
            this.btnAOtiDeleteInfo.Click += new System.EventHandler(this.btnAOtiDeleteInfo_Click);
            // 
            // btnAOtiEditInfo
            // 
            this.btnAOtiEditInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiEditInfo.FlatAppearance.BorderSize = 0;
            this.btnAOtiEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiEditInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiEditInfo.Location = new System.Drawing.Point(0, 35);
            this.btnAOtiEditInfo.Name = "btnAOtiEditInfo";
            this.btnAOtiEditInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAOtiEditInfo.Size = new System.Drawing.Size(183, 35);
            this.btnAOtiEditInfo.TabIndex = 2;
            this.btnAOtiEditInfo.Text = "Edit Occupant";
            this.btnAOtiEditInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAOtiEditInfo.UseVisualStyleBackColor = true;
            this.btnAOtiEditInfo.Click += new System.EventHandler(this.btnAOtiEditInfo_Click);
            // 
            // btnAOtiAddOccupant
            // 
            this.btnAOtiAddOccupant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiAddOccupant.FlatAppearance.BorderSize = 0;
            this.btnAOtiAddOccupant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiAddOccupant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiAddOccupant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiAddOccupant.Location = new System.Drawing.Point(0, 0);
            this.btnAOtiAddOccupant.Name = "btnAOtiAddOccupant";
            this.btnAOtiAddOccupant.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAOtiAddOccupant.Size = new System.Drawing.Size(183, 35);
            this.btnAOtiAddOccupant.TabIndex = 1;
            this.btnAOtiAddOccupant.Text = "Add Occupant";
            this.btnAOtiAddOccupant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAOtiAddOccupant.UseVisualStyleBackColor = true;
            this.btnAOtiAddOccupant.Click += new System.EventHandler(this.btnAOtiAddOccupant_Click);
            // 
            // btnAOtiModify
            // 
            this.btnAOtiModify.AutoSize = true;
            this.btnAOtiModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiModify.FlatAppearance.BorderSize = 0;
            this.btnAOtiModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiModify.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiModify.Location = new System.Drawing.Point(0, 517);
            this.btnAOtiModify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAOtiModify.Name = "btnAOtiModify";
            this.btnAOtiModify.Size = new System.Drawing.Size(183, 39);
            this.btnAOtiModify.TabIndex = 10;
            this.btnAOtiModify.Text = "Modify Occupant";
            this.btnAOtiModify.UseVisualStyleBackColor = true;
            this.btnAOtiModify.Click += new System.EventHandler(this.btnAOtiModify_Click);
            // 
            // pnlAOtiFilter
            // 
            this.pnlAOtiFilter.AutoSize = true;
            this.pnlAOtiFilter.Controls.Add(this.btnAOtiFilterShow);
            this.pnlAOtiFilter.Controls.Add(this.cBoxAOtiFilter);
            this.pnlAOtiFilter.Controls.Add(this.label3);
            this.pnlAOtiFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAOtiFilter.Location = new System.Drawing.Point(0, 397);
            this.pnlAOtiFilter.Name = "pnlAOtiFilter";
            this.pnlAOtiFilter.Size = new System.Drawing.Size(183, 120);
            this.pnlAOtiFilter.TabIndex = 9;
            this.pnlAOtiFilter.Visible = false;
            // 
            // btnAOtiFilterShow
            // 
            this.btnAOtiFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAOtiFilterShow.FlatAppearance.BorderSize = 2;
            this.btnAOtiFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiFilterShow.Location = new System.Drawing.Point(47, 87);
            this.btnAOtiFilterShow.Name = "btnAOtiFilterShow";
            this.btnAOtiFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnAOtiFilterShow.TabIndex = 5;
            this.btnAOtiFilterShow.Text = "FILTER";
            this.btnAOtiFilterShow.UseVisualStyleBackColor = true;
            this.btnAOtiFilterShow.Click += new System.EventHandler(this.btnAOtiFilterShow_Click);
            // 
            // cBoxAOtiFilter
            // 
            this.cBoxAOtiFilter.FormattingEnabled = true;
            this.cBoxAOtiFilter.Items.AddRange(new object[] {
            "Rental Shop",
            "Apartment",
            "Split-Level",
            "Villa"});
            this.cBoxAOtiFilter.Location = new System.Drawing.Point(24, 45);
            this.cBoxAOtiFilter.Name = "cBoxAOtiFilter";
            this.cBoxAOtiFilter.Size = new System.Drawing.Size(150, 23);
            this.cBoxAOtiFilter.TabIndex = 3;
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
            // btnAOtiFilter
            // 
            this.btnAOtiFilter.AutoSize = true;
            this.btnAOtiFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiFilter.FlatAppearance.BorderSize = 0;
            this.btnAOtiFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiFilter.Location = new System.Drawing.Point(0, 358);
            this.btnAOtiFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAOtiFilter.Name = "btnAOtiFilter";
            this.btnAOtiFilter.Size = new System.Drawing.Size(183, 39);
            this.btnAOtiFilter.TabIndex = 8;
            this.btnAOtiFilter.Text = "Filter";
            this.btnAOtiFilter.UseVisualStyleBackColor = true;
            this.btnAOtiFilter.Click += new System.EventHandler(this.btnAOtiFilter_Click);
            // 
            // pnlAOtiSearch
            // 
            this.pnlAOtiSearch.AutoScroll = true;
            this.pnlAOtiSearch.AutoSize = true;
            this.pnlAOtiSearch.Controls.Add(this.btnAOtiSearchShow);
            this.pnlAOtiSearch.Controls.Add(this.rb_AOtiByPhone);
            this.pnlAOtiSearch.Controls.Add(this.rb_AOtiByName);
            this.pnlAOtiSearch.Controls.Add(this.label2);
            this.pnlAOtiSearch.Controls.Add(this.txtAOtiSearch);
            this.pnlAOtiSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAOtiSearch.Location = new System.Drawing.Point(0, 178);
            this.pnlAOtiSearch.Name = "pnlAOtiSearch";
            this.pnlAOtiSearch.Size = new System.Drawing.Size(183, 180);
            this.pnlAOtiSearch.TabIndex = 6;
            this.pnlAOtiSearch.Visible = false;
            // 
            // btnAOtiSearchShow
            // 
            this.btnAOtiSearchShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAOtiSearchShow.FlatAppearance.BorderSize = 2;
            this.btnAOtiSearchShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiSearchShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiSearchShow.Location = new System.Drawing.Point(47, 147);
            this.btnAOtiSearchShow.Name = "btnAOtiSearchShow";
            this.btnAOtiSearchShow.Size = new System.Drawing.Size(100, 30);
            this.btnAOtiSearchShow.TabIndex = 4;
            this.btnAOtiSearchShow.Text = "SEARCH";
            this.btnAOtiSearchShow.UseVisualStyleBackColor = true;
            this.btnAOtiSearchShow.Click += new System.EventHandler(this.btnAOtiSearchShow_Click);
            // 
            // rb_AOtiByPhone
            // 
            this.rb_AOtiByPhone.AutoSize = true;
            this.rb_AOtiByPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_AOtiByPhone.ForeColor = System.Drawing.Color.White;
            this.rb_AOtiByPhone.Location = new System.Drawing.Point(24, 108);
            this.rb_AOtiByPhone.Name = "rb_AOtiByPhone";
            this.rb_AOtiByPhone.Size = new System.Drawing.Size(113, 19);
            this.rb_AOtiByPhone.TabIndex = 3;
            this.rb_AOtiByPhone.TabStop = true;
            this.rb_AOtiByPhone.Text = "Search By Phone";
            this.rb_AOtiByPhone.UseVisualStyleBackColor = true;
            this.rb_AOtiByPhone.CheckedChanged += new System.EventHandler(this.rb_AOtiByPhone_CheckedChanged);
            // 
            // rb_AOtiByName
            // 
            this.rb_AOtiByName.AutoSize = true;
            this.rb_AOtiByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_AOtiByName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rb_AOtiByName.FlatAppearance.BorderSize = 0;
            this.rb_AOtiByName.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rb_AOtiByName.ForeColor = System.Drawing.Color.White;
            this.rb_AOtiByName.Location = new System.Drawing.Point(24, 83);
            this.rb_AOtiByName.Name = "rb_AOtiByName";
            this.rb_AOtiByName.Size = new System.Drawing.Size(111, 19);
            this.rb_AOtiByName.TabIndex = 2;
            this.rb_AOtiByName.TabStop = true;
            this.rb_AOtiByName.Text = "Search By Name";
            this.rb_AOtiByName.UseVisualStyleBackColor = true;
            this.rb_AOtiByName.CheckedChanged += new System.EventHandler(this.rb_AOtiByName_CheckedChanged);
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
            // txtAOtiSearch
            // 
            this.txtAOtiSearch.Location = new System.Drawing.Point(24, 39);
            this.txtAOtiSearch.Name = "txtAOtiSearch";
            this.txtAOtiSearch.PlaceholderText = "Search";
            this.txtAOtiSearch.Size = new System.Drawing.Size(150, 23);
            this.txtAOtiSearch.TabIndex = 0;
            // 
            // btnAOtiSearch
            // 
            this.btnAOtiSearch.AutoSize = true;
            this.btnAOtiSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiSearch.FlatAppearance.BorderSize = 0;
            this.btnAOtiSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiSearch.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiSearch.Location = new System.Drawing.Point(0, 139);
            this.btnAOtiSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAOtiSearch.Name = "btnAOtiSearch";
            this.btnAOtiSearch.Size = new System.Drawing.Size(183, 39);
            this.btnAOtiSearch.TabIndex = 5;
            this.btnAOtiSearch.Text = "Search Occupant";
            this.btnAOtiSearch.UseVisualStyleBackColor = true;
            this.btnAOtiSearch.Click += new System.EventHandler(this.btnAOtiSearch_Click);
            // 
            // btnAOtiViewAll
            // 
            this.btnAOtiViewAll.AutoSize = true;
            this.btnAOtiViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAOtiViewAll.FlatAppearance.BorderSize = 0;
            this.btnAOtiViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOtiViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOtiViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAOtiViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnAOtiViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAOtiViewAll.Name = "btnAOtiViewAll";
            this.btnAOtiViewAll.Size = new System.Drawing.Size(183, 39);
            this.btnAOtiViewAll.TabIndex = 4;
            this.btnAOtiViewAll.Text = "View All Occupants";
            this.btnAOtiViewAll.UseVisualStyleBackColor = true;
            this.btnAOtiViewAll.Click += new System.EventHandler(this.btnAOtiViewAll_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 100);
            this.panel1.TabIndex = 3;
            // 
            // pnlAOtiContainer
            // 
            this.pnlAOtiContainer.Controls.Add(this.dgv_Occupants);
            this.pnlAOtiContainer.Controls.Add(this.label1);
            this.pnlAOtiContainer.Location = new System.Drawing.Point(206, 0);
            this.pnlAOtiContainer.Name = "pnlAOtiContainer";
            this.pnlAOtiContainer.Size = new System.Drawing.Size(1018, 564);
            this.pnlAOtiContainer.TabIndex = 5;
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
            // uc_OccupantAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlAOtiContainer);
            this.Controls.Add(this.pnlAOtiSideNav);
            this.Name = "uc_OccupantAdmin";
            this.Size = new System.Drawing.Size(1224, 564);
            this.Load += new System.EventHandler(this.uc_OccupantAdmin_Load);
            this.pnlAOtiSideNav.ResumeLayout(false);
            this.pnlAOtiSideNav.PerformLayout();
            this.pnlAOtiModify.ResumeLayout(false);
            this.pnlAOtiFilter.ResumeLayout(false);
            this.pnlAOtiFilter.PerformLayout();
            this.pnlAOtiSearch.ResumeLayout(false);
            this.pnlAOtiSearch.PerformLayout();
            this.pnlAOtiContainer.ResumeLayout(false);
            this.pnlAOtiContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Occupants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAOtiSideNav;
        private System.Windows.Forms.Panel pnlAOtiFilter;
        private System.Windows.Forms.Button btnAOtiFilterShow;
        private System.Windows.Forms.ComboBox cBoxAOtiFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAOtiFilter;
        private System.Windows.Forms.Panel pnlAOtiSearch;
        private System.Windows.Forms.Button btnAOtiSearchShow;
        private System.Windows.Forms.RadioButton rb_AOtiByPhone;
        private System.Windows.Forms.RadioButton rb_AOtiByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAOtiSearch;
        private System.Windows.Forms.Button btnAOtiSearch;
        private System.Windows.Forms.Button btnAOtiViewAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAOtiContainer;
        private System.Windows.Forms.DataGridView dgv_Occupants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAOtiModify;
        private System.Windows.Forms.Button btnAOtiModify;
        private System.Windows.Forms.Button btnAOtiDeleteInfo;
        private System.Windows.Forms.Button btnAOtiEditInfo;
        private System.Windows.Forms.Button btnAOtiAddOccupant;
    }
}
