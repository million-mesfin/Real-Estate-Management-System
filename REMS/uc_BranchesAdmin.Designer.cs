
namespace REMS
{
    partial class uc_BranchesAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBranchContainer = new System.Windows.Forms.Panel();
            this.dgv_Branches = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlABrnModify = new System.Windows.Forms.Panel();
            this.btnABrnDelete = new System.Windows.Forms.Button();
            this.btnABrnEdit = new System.Windows.Forms.Button();
            this.btnABrnAdd = new System.Windows.Forms.Button();
            this.btnABrnModify = new System.Windows.Forms.Button();
            this.pnlABrnFilter = new System.Windows.Forms.Panel();
            this.txtABrnFilterBranchType = new System.Windows.Forms.TextBox();
            this.txtABrnFilterCity = new System.Windows.Forms.TextBox();
            this.cBoxABrnFilterRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnABrnFilterShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnABrnFilter = new System.Windows.Forms.Button();
            this.btnABrnViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBranchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Branches)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlABrnModify.SuspendLayout();
            this.pnlABrnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBranchContainer
            // 
            this.pnlBranchContainer.Controls.Add(this.dgv_Branches);
            this.pnlBranchContainer.Controls.Add(this.label5);
            this.pnlBranchContainer.Location = new System.Drawing.Point(208, 3);
            this.pnlBranchContainer.Name = "pnlBranchContainer";
            this.pnlBranchContainer.Size = new System.Drawing.Size(1014, 560);
            this.pnlBranchContainer.TabIndex = 3;
            // 
            // dgv_Branches
            // 
            this.dgv_Branches.AllowUserToAddRows = false;
            this.dgv_Branches.AllowUserToDeleteRows = false;
            this.dgv_Branches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Branches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Branches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Branches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Branches.DefaultCellStyle = dataGridViewCellStyle8;
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlABrnModify);
            this.panel1.Controls.Add(this.btnABrnModify);
            this.panel1.Controls.Add(this.pnlABrnFilter);
            this.panel1.Controls.Add(this.btnABrnFilter);
            this.panel1.Controls.Add(this.btnABrnViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 564);
            this.panel1.TabIndex = 2;
            // 
            // pnlABrnModify
            // 
            this.pnlABrnModify.Controls.Add(this.btnABrnDelete);
            this.pnlABrnModify.Controls.Add(this.btnABrnEdit);
            this.pnlABrnModify.Controls.Add(this.btnABrnAdd);
            this.pnlABrnModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlABrnModify.Location = new System.Drawing.Point(0, 442);
            this.pnlABrnModify.Name = "pnlABrnModify";
            this.pnlABrnModify.Size = new System.Drawing.Size(200, 111);
            this.pnlABrnModify.TabIndex = 14;
            this.pnlABrnModify.Visible = false;
            // 
            // btnABrnDelete
            // 
            this.btnABrnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABrnDelete.FlatAppearance.BorderSize = 0;
            this.btnABrnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnABrnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnDelete.Location = new System.Drawing.Point(0, 64);
            this.btnABrnDelete.Name = "btnABrnDelete";
            this.btnABrnDelete.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnABrnDelete.Size = new System.Drawing.Size(200, 32);
            this.btnABrnDelete.TabIndex = 9;
            this.btnABrnDelete.Text = "Delete Branch";
            this.btnABrnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABrnDelete.UseVisualStyleBackColor = true;
            this.btnABrnDelete.Click += new System.EventHandler(this.btnABrnDelete_Click);
            // 
            // btnABrnEdit
            // 
            this.btnABrnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABrnEdit.FlatAppearance.BorderSize = 0;
            this.btnABrnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnABrnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnEdit.Location = new System.Drawing.Point(0, 32);
            this.btnABrnEdit.Name = "btnABrnEdit";
            this.btnABrnEdit.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnABrnEdit.Size = new System.Drawing.Size(200, 32);
            this.btnABrnEdit.TabIndex = 8;
            this.btnABrnEdit.Text = "Edit Branch";
            this.btnABrnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABrnEdit.UseVisualStyleBackColor = true;
            this.btnABrnEdit.Click += new System.EventHandler(this.btnABrnEdit_Click);
            // 
            // btnABrnAdd
            // 
            this.btnABrnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABrnAdd.FlatAppearance.BorderSize = 0;
            this.btnABrnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnABrnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnABrnAdd.Name = "btnABrnAdd";
            this.btnABrnAdd.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnABrnAdd.Size = new System.Drawing.Size(200, 32);
            this.btnABrnAdd.TabIndex = 7;
            this.btnABrnAdd.Text = "Add Branch";
            this.btnABrnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABrnAdd.UseVisualStyleBackColor = true;
            this.btnABrnAdd.Click += new System.EventHandler(this.btnABrnAdd_Click);
            // 
            // btnABrnModify
            // 
            this.btnABrnModify.AutoSize = true;
            this.btnABrnModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABrnModify.FlatAppearance.BorderSize = 0;
            this.btnABrnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnModify.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnABrnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnModify.Location = new System.Drawing.Point(0, 403);
            this.btnABrnModify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnABrnModify.Name = "btnABrnModify";
            this.btnABrnModify.Size = new System.Drawing.Size(200, 39);
            this.btnABrnModify.TabIndex = 13;
            this.btnABrnModify.Text = "Modify Branches";
            this.btnABrnModify.UseVisualStyleBackColor = true;
            this.btnABrnModify.Click += new System.EventHandler(this.btnABrnModify_Click);
            // 
            // pnlABrnFilter
            // 
            this.pnlABrnFilter.Controls.Add(this.txtABrnFilterBranchType);
            this.pnlABrnFilter.Controls.Add(this.txtABrnFilterCity);
            this.pnlABrnFilter.Controls.Add(this.cBoxABrnFilterRegion);
            this.pnlABrnFilter.Controls.Add(this.label4);
            this.pnlABrnFilter.Controls.Add(this.label3);
            this.pnlABrnFilter.Controls.Add(this.btnABrnFilterShow);
            this.pnlABrnFilter.Controls.Add(this.label1);
            this.pnlABrnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlABrnFilter.Location = new System.Drawing.Point(0, 178);
            this.pnlABrnFilter.Name = "pnlABrnFilter";
            this.pnlABrnFilter.Size = new System.Drawing.Size(200, 225);
            this.pnlABrnFilter.TabIndex = 12;
            this.pnlABrnFilter.Visible = false;
            // 
            // txtABrnFilterBranchType
            // 
            this.txtABrnFilterBranchType.Location = new System.Drawing.Point(27, 147);
            this.txtABrnFilterBranchType.Name = "txtABrnFilterBranchType";
            this.txtABrnFilterBranchType.PlaceholderText = "Branch type";
            this.txtABrnFilterBranchType.Size = new System.Drawing.Size(150, 23);
            this.txtABrnFilterBranchType.TabIndex = 11;
            // 
            // txtABrnFilterCity
            // 
            this.txtABrnFilterCity.Location = new System.Drawing.Point(27, 92);
            this.txtABrnFilterCity.Name = "txtABrnFilterCity";
            this.txtABrnFilterCity.PlaceholderText = "City name";
            this.txtABrnFilterCity.Size = new System.Drawing.Size(150, 23);
            this.txtABrnFilterCity.TabIndex = 10;
            // 
            // cBoxABrnFilterRegion
            // 
            this.cBoxABrnFilterRegion.FormattingEnabled = true;
            this.cBoxABrnFilterRegion.Items.AddRange(new object[] {
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
            this.cBoxABrnFilterRegion.Location = new System.Drawing.Point(27, 39);
            this.cBoxABrnFilterRegion.Name = "cBoxABrnFilterRegion";
            this.cBoxABrnFilterRegion.Size = new System.Drawing.Size(150, 23);
            this.cBoxABrnFilterRegion.TabIndex = 9;
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
            // btnABrnFilterShow
            // 
            this.btnABrnFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABrnFilterShow.FlatAppearance.BorderSize = 2;
            this.btnABrnFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnFilterShow.Location = new System.Drawing.Point(51, 192);
            this.btnABrnFilterShow.Name = "btnABrnFilterShow";
            this.btnABrnFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnABrnFilterShow.TabIndex = 6;
            this.btnABrnFilterShow.Text = "FILTER";
            this.btnABrnFilterShow.UseVisualStyleBackColor = true;
            this.btnABrnFilterShow.Click += new System.EventHandler(this.btnABrnFilterShow_Click);
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
            // btnABrnFilter
            // 
            this.btnABrnFilter.AutoSize = true;
            this.btnABrnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABrnFilter.FlatAppearance.BorderSize = 0;
            this.btnABrnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnABrnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnFilter.Location = new System.Drawing.Point(0, 139);
            this.btnABrnFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnABrnFilter.Name = "btnABrnFilter";
            this.btnABrnFilter.Size = new System.Drawing.Size(200, 39);
            this.btnABrnFilter.TabIndex = 11;
            this.btnABrnFilter.Text = "Filter";
            this.btnABrnFilter.UseVisualStyleBackColor = true;
            this.btnABrnFilter.Click += new System.EventHandler(this.btnABrnFilter_Click);
            // 
            // btnABrnViewAll
            // 
            this.btnABrnViewAll.AutoSize = true;
            this.btnABrnViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABrnViewAll.FlatAppearance.BorderSize = 0;
            this.btnABrnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABrnViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnABrnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnABrnViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnABrnViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnABrnViewAll.Name = "btnABrnViewAll";
            this.btnABrnViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnABrnViewAll.TabIndex = 8;
            this.btnABrnViewAll.Text = "View All Branches";
            this.btnABrnViewAll.UseVisualStyleBackColor = true;
            this.btnABrnViewAll.Click += new System.EventHandler(this.btnABrnViewAll_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // uc_BranchesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlBranchContainer);
            this.Controls.Add(this.panel1);
            this.Name = "uc_BranchesAdmin";
            this.Size = new System.Drawing.Size(1224, 564);
            this.Load += new System.EventHandler(this.uc_BranchesAdmin_Load);
            this.pnlBranchContainer.ResumeLayout(false);
            this.pnlBranchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Branches)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlABrnModify.ResumeLayout(false);
            this.pnlABrnFilter.ResumeLayout(false);
            this.pnlABrnFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBranchContainer;
        private System.Windows.Forms.DataGridView dgv_Branches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlABrnModify;
        private System.Windows.Forms.Button btnABrnModify;
        private System.Windows.Forms.Panel pnlABrnFilter;
        private System.Windows.Forms.TextBox txtABrnFilterBranchType;
        private System.Windows.Forms.TextBox txtABrnFilterCity;
        private System.Windows.Forms.ComboBox cBoxABrnFilterRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnABrnFilterShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnABrnFilter;
        private System.Windows.Forms.Button btnABrnViewAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnABrnDelete;
        private System.Windows.Forms.Button btnABrnEdit;
        private System.Windows.Forms.Button btnABrnAdd;
    }
}
