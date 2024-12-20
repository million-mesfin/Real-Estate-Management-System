
namespace REMS
{
    partial class uc_ClearLotAdmin
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
            this.pnlACplModify = new System.Windows.Forms.Panel();
            this.btnAcplDeleteInfo = new System.Windows.Forms.Button();
            this.btnACplEditInfo = new System.Windows.Forms.Button();
            this.btnACplAdd = new System.Windows.Forms.Button();
            this.btnACplModify = new System.Windows.Forms.Button();
            this.pnlACplFilter = new System.Windows.Forms.Panel();
            this.txtACplFilterCity = new System.Windows.Forms.TextBox();
            this.cBoxACplFilterPermit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnACplFilterShow = new System.Windows.Forms.Button();
            this.cBoxACplFilterRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnACplFilter = new System.Windows.Forms.Button();
            this.btnACplViewAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlAClearLotContainer = new System.Windows.Forms.Panel();
            this.dgv_ClearPlot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlACplModify.SuspendLayout();
            this.pnlACplFilter.SuspendLayout();
            this.pnlAClearLotContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClearPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlACplModify);
            this.panel1.Controls.Add(this.btnACplModify);
            this.panel1.Controls.Add(this.pnlACplFilter);
            this.panel1.Controls.Add(this.btnACplFilter);
            this.panel1.Controls.Add(this.btnACplViewAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 1;
            // 
            // pnlACplModify
            // 
            this.pnlACplModify.Controls.Add(this.btnAcplDeleteInfo);
            this.pnlACplModify.Controls.Add(this.btnACplEditInfo);
            this.pnlACplModify.Controls.Add(this.btnACplAdd);
            this.pnlACplModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlACplModify.Location = new System.Drawing.Point(0, 438);
            this.pnlACplModify.Name = "pnlACplModify";
            this.pnlACplModify.Size = new System.Drawing.Size(200, 106);
            this.pnlACplModify.TabIndex = 12;
            this.pnlACplModify.Visible = false;
            // 
            // btnAcplDeleteInfo
            // 
            this.btnAcplDeleteInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcplDeleteInfo.FlatAppearance.BorderSize = 0;
            this.btnAcplDeleteInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcplDeleteInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcplDeleteInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAcplDeleteInfo.Location = new System.Drawing.Point(0, 70);
            this.btnAcplDeleteInfo.Name = "btnAcplDeleteInfo";
            this.btnAcplDeleteInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAcplDeleteInfo.Size = new System.Drawing.Size(200, 35);
            this.btnAcplDeleteInfo.TabIndex = 3;
            this.btnAcplDeleteInfo.Text = "Delete Lot";
            this.btnAcplDeleteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcplDeleteInfo.UseVisualStyleBackColor = true;
            this.btnAcplDeleteInfo.Click += new System.EventHandler(this.btnAcplDeleteInfo_Click);
            // 
            // btnACplEditInfo
            // 
            this.btnACplEditInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnACplEditInfo.FlatAppearance.BorderSize = 0;
            this.btnACplEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACplEditInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnACplEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnACplEditInfo.Location = new System.Drawing.Point(0, 35);
            this.btnACplEditInfo.Name = "btnACplEditInfo";
            this.btnACplEditInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnACplEditInfo.Size = new System.Drawing.Size(200, 35);
            this.btnACplEditInfo.TabIndex = 2;
            this.btnACplEditInfo.Text = "Edit Lot";
            this.btnACplEditInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACplEditInfo.UseVisualStyleBackColor = true;
            this.btnACplEditInfo.Click += new System.EventHandler(this.btnACplEditInfo_Click);
            // 
            // btnACplAdd
            // 
            this.btnACplAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnACplAdd.FlatAppearance.BorderSize = 0;
            this.btnACplAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACplAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnACplAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnACplAdd.Location = new System.Drawing.Point(0, 0);
            this.btnACplAdd.Name = "btnACplAdd";
            this.btnACplAdd.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnACplAdd.Size = new System.Drawing.Size(200, 35);
            this.btnACplAdd.TabIndex = 1;
            this.btnACplAdd.Text = "Add Lot";
            this.btnACplAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACplAdd.UseVisualStyleBackColor = true;
            this.btnACplAdd.Click += new System.EventHandler(this.btnACplAdd_Click);
            // 
            // btnACplModify
            // 
            this.btnACplModify.AutoSize = true;
            this.btnACplModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnACplModify.FlatAppearance.BorderSize = 0;
            this.btnACplModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACplModify.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnACplModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnACplModify.Location = new System.Drawing.Point(0, 399);
            this.btnACplModify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnACplModify.Name = "btnACplModify";
            this.btnACplModify.Size = new System.Drawing.Size(200, 39);
            this.btnACplModify.TabIndex = 11;
            this.btnACplModify.Text = "Modify Clear Lot";
            this.btnACplModify.UseVisualStyleBackColor = true;
            this.btnACplModify.Click += new System.EventHandler(this.btnACplModify_Click);
            // 
            // pnlACplFilter
            // 
            this.pnlACplFilter.AutoSize = true;
            this.pnlACplFilter.Controls.Add(this.txtACplFilterCity);
            this.pnlACplFilter.Controls.Add(this.cBoxACplFilterPermit);
            this.pnlACplFilter.Controls.Add(this.label4);
            this.pnlACplFilter.Controls.Add(this.label2);
            this.pnlACplFilter.Controls.Add(this.btnACplFilterShow);
            this.pnlACplFilter.Controls.Add(this.cBoxACplFilterRegion);
            this.pnlACplFilter.Controls.Add(this.label3);
            this.pnlACplFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlACplFilter.Location = new System.Drawing.Point(0, 178);
            this.pnlACplFilter.Name = "pnlACplFilter";
            this.pnlACplFilter.Size = new System.Drawing.Size(200, 221);
            this.pnlACplFilter.TabIndex = 10;
            this.pnlACplFilter.Visible = false;
            // 
            // txtACplFilterCity
            // 
            this.txtACplFilterCity.Location = new System.Drawing.Point(24, 93);
            this.txtACplFilterCity.Name = "txtACplFilterCity";
            this.txtACplFilterCity.PlaceholderText = "Enter city name";
            this.txtACplFilterCity.Size = new System.Drawing.Size(149, 23);
            this.txtACplFilterCity.TabIndex = 10;
            // 
            // cBoxACplFilterPermit
            // 
            this.cBoxACplFilterPermit.FormattingEnabled = true;
            this.cBoxACplFilterPermit.Items.AddRange(new object[] {
            "Active",
            "Pending",
            "On Hold"});
            this.cBoxACplFilterPermit.Location = new System.Drawing.Point(24, 146);
            this.cBoxACplFilterPermit.Name = "cBoxACplFilterPermit";
            this.cBoxACplFilterPermit.Size = new System.Drawing.Size(150, 23);
            this.cBoxACplFilterPermit.TabIndex = 9;
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
            // btnACplFilterShow
            // 
            this.btnACplFilterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnACplFilterShow.FlatAppearance.BorderSize = 2;
            this.btnACplFilterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACplFilterShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnACplFilterShow.Location = new System.Drawing.Point(50, 188);
            this.btnACplFilterShow.Name = "btnACplFilterShow";
            this.btnACplFilterShow.Size = new System.Drawing.Size(100, 30);
            this.btnACplFilterShow.TabIndex = 5;
            this.btnACplFilterShow.Text = "FILTER";
            this.btnACplFilterShow.UseVisualStyleBackColor = true;
            this.btnACplFilterShow.Click += new System.EventHandler(this.btnACplFilterShow_Click);
            // 
            // cBoxACplFilterRegion
            // 
            this.cBoxACplFilterRegion.FormattingEnabled = true;
            this.cBoxACplFilterRegion.Items.AddRange(new object[] {
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
            this.cBoxACplFilterRegion.Location = new System.Drawing.Point(24, 36);
            this.cBoxACplFilterRegion.Name = "cBoxACplFilterRegion";
            this.cBoxACplFilterRegion.Size = new System.Drawing.Size(150, 23);
            this.cBoxACplFilterRegion.TabIndex = 3;
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
            // btnACplFilter
            // 
            this.btnACplFilter.AutoSize = true;
            this.btnACplFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnACplFilter.FlatAppearance.BorderSize = 0;
            this.btnACplFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACplFilter.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnACplFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnACplFilter.Location = new System.Drawing.Point(0, 139);
            this.btnACplFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnACplFilter.Name = "btnACplFilter";
            this.btnACplFilter.Size = new System.Drawing.Size(200, 39);
            this.btnACplFilter.TabIndex = 9;
            this.btnACplFilter.Text = "Filter";
            this.btnACplFilter.UseVisualStyleBackColor = true;
            this.btnACplFilter.Click += new System.EventHandler(this.btnACplFilter_Click);
            // 
            // btnACplViewAll
            // 
            this.btnACplViewAll.AutoSize = true;
            this.btnACplViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnACplViewAll.FlatAppearance.BorderSize = 0;
            this.btnACplViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACplViewAll.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnACplViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnACplViewAll.Location = new System.Drawing.Point(0, 100);
            this.btnACplViewAll.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnACplViewAll.Name = "btnACplViewAll";
            this.btnACplViewAll.Size = new System.Drawing.Size(200, 39);
            this.btnACplViewAll.TabIndex = 5;
            this.btnACplViewAll.Text = "View All Clear Lots";
            this.btnACplViewAll.UseVisualStyleBackColor = true;
            this.btnACplViewAll.Click += new System.EventHandler(this.btnACplViewAll_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // pnlAClearLotContainer
            // 
            this.pnlAClearLotContainer.Controls.Add(this.dgv_ClearPlot);
            this.pnlAClearLotContainer.Controls.Add(this.label1);
            this.pnlAClearLotContainer.Location = new System.Drawing.Point(206, 0);
            this.pnlAClearLotContainer.Name = "pnlAClearLotContainer";
            this.pnlAClearLotContainer.Size = new System.Drawing.Size(1014, 563);
            this.pnlAClearLotContainer.TabIndex = 2;
            // 
            // dgv_ClearPlot
            // 
            this.dgv_ClearPlot.AllowUserToAddRows = false;
            this.dgv_ClearPlot.AllowUserToDeleteRows = false;
            this.dgv_ClearPlot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_ClearPlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ClearPlot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClearPlot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ClearPlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ClearPlot.DefaultCellStyle = dataGridViewCellStyle2;
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
            // uc_ClearLotAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlAClearLotContainer);
            this.Controls.Add(this.panel1);
            this.Name = "uc_ClearLotAdmin";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_ClearLotAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlACplModify.ResumeLayout(false);
            this.pnlACplFilter.ResumeLayout(false);
            this.pnlACplFilter.PerformLayout();
            this.pnlAClearLotContainer.ResumeLayout(false);
            this.pnlAClearLotContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClearPlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlACplFilter;
        private System.Windows.Forms.TextBox txtACplFilterCity;
        private System.Windows.Forms.ComboBox cBoxACplFilterPermit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnACplFilterShow;
        private System.Windows.Forms.ComboBox cBoxACplFilterRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnACplFilter;
        private System.Windows.Forms.Button btnACplViewAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlAClearLotContainer;
        private System.Windows.Forms.DataGridView dgv_ClearPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnACplModify;
        private System.Windows.Forms.Panel pnlACplModify;
        private System.Windows.Forms.Button btnAcplDeleteInfo;
        private System.Windows.Forms.Button btnACplEditInfo;
        private System.Windows.Forms.Button btnACplAdd;
    }
}
