
namespace REMS
{
    partial class uc_Apartments
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserAptFilter = new System.Windows.Forms.Button();
            this.dgv_Apartments = new System.Windows.Forms.DataGridView();
            this.pnlUAptFilter = new System.Windows.Forms.Panel();
            this.btnUAptFilterOk = new System.Windows.Forms.Button();
            this.btnUAptFilterCancle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cBoxUAptFilterStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_UAptFilterStatus = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUAptFilterCont = new System.Windows.Forms.TextBox();
            this.cb_UAptFilterCont = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUAptFilterCity = new System.Windows.Forms.TextBox();
            this.cb_UAptFilterCity = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBoxUAptFilterRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_UAptFilterRegion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Apartments)).BeginInit();
            this.pnlUAptFilter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apartments";
            // 
            // btnUserAptFilter
            // 
            this.btnUserAptFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUserAptFilter.FlatAppearance.BorderSize = 0;
            this.btnUserAptFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAptFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserAptFilter.Location = new System.Drawing.Point(827, 30);
            this.btnUserAptFilter.Name = "btnUserAptFilter";
            this.btnUserAptFilter.Size = new System.Drawing.Size(150, 45);
            this.btnUserAptFilter.TabIndex = 2;
            this.btnUserAptFilter.Text = "Filter";
            this.btnUserAptFilter.UseVisualStyleBackColor = false;
            this.btnUserAptFilter.Click += new System.EventHandler(this.btnUserAptFilter_Click);
            // 
            // dgv_Apartments
            // 
            this.dgv_Apartments.AllowUserToAddRows = false;
            this.dgv_Apartments.AllowUserToDeleteRows = false;
            this.dgv_Apartments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Apartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Apartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Apartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Apartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Apartments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Apartments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Apartments.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Apartments.Location = new System.Drawing.Point(30, 99);
            this.dgv_Apartments.Name = "dgv_Apartments";
            this.dgv_Apartments.ReadOnly = true;
            this.dgv_Apartments.RowTemplate.Height = 25;
            this.dgv_Apartments.Size = new System.Drawing.Size(947, 432);
            this.dgv_Apartments.TabIndex = 3;
            // 
            // pnlUAptFilter
            // 
            this.pnlUAptFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnlUAptFilter.Controls.Add(this.btnUAptFilterOk);
            this.pnlUAptFilter.Controls.Add(this.btnUAptFilterCancle);
            this.pnlUAptFilter.Controls.Add(this.panel5);
            this.pnlUAptFilter.Controls.Add(this.cb_UAptFilterStatus);
            this.pnlUAptFilter.Controls.Add(this.panel4);
            this.pnlUAptFilter.Controls.Add(this.cb_UAptFilterCont);
            this.pnlUAptFilter.Controls.Add(this.panel3);
            this.pnlUAptFilter.Controls.Add(this.cb_UAptFilterCity);
            this.pnlUAptFilter.Controls.Add(this.panel2);
            this.pnlUAptFilter.Controls.Add(this.cb_UAptFilterRegion);
            this.pnlUAptFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUAptFilter.Location = new System.Drawing.Point(713, 0);
            this.pnlUAptFilter.Name = "pnlUAptFilter";
            this.pnlUAptFilter.Size = new System.Drawing.Size(300, 562);
            this.pnlUAptFilter.TabIndex = 4;
            this.pnlUAptFilter.Visible = false;
            // 
            // btnUAptFilterOk
            // 
            this.btnUAptFilterOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUAptFilterOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUAptFilterOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUAptFilterOk.FlatAppearance.BorderSize = 2;
            this.btnUAptFilterOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUAptFilterOk.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUAptFilterOk.ForeColor = System.Drawing.Color.Black;
            this.btnUAptFilterOk.Location = new System.Drawing.Point(175, 487);
            this.btnUAptFilterOk.Name = "btnUAptFilterOk";
            this.btnUAptFilterOk.Size = new System.Drawing.Size(90, 35);
            this.btnUAptFilterOk.TabIndex = 8;
            this.btnUAptFilterOk.Text = "OK";
            this.btnUAptFilterOk.UseVisualStyleBackColor = false;
            this.btnUAptFilterOk.Click += new System.EventHandler(this.btnUAptFilterOk_Click);
            // 
            // btnUAptFilterCancle
            // 
            this.btnUAptFilterCancle.BackColor = System.Drawing.Color.Transparent;
            this.btnUAptFilterCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUAptFilterCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUAptFilterCancle.FlatAppearance.BorderSize = 2;
            this.btnUAptFilterCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUAptFilterCancle.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUAptFilterCancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnUAptFilterCancle.Location = new System.Drawing.Point(20, 487);
            this.btnUAptFilterCancle.Name = "btnUAptFilterCancle";
            this.btnUAptFilterCancle.Size = new System.Drawing.Size(90, 35);
            this.btnUAptFilterCancle.TabIndex = 7;
            this.btnUAptFilterCancle.Text = "CANCLE";
            this.btnUAptFilterCancle.UseVisualStyleBackColor = false;
            this.btnUAptFilterCancle.Click += new System.EventHandler(this.btnUAptFilterCancle_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cBoxUAptFilterStatus);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 361);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 90);
            this.panel5.TabIndex = 4;
            // 
            // cBoxUAptFilterStatus
            // 
            this.cBoxUAptFilterStatus.Enabled = false;
            this.cBoxUAptFilterStatus.FormattingEnabled = true;
            this.cBoxUAptFilterStatus.Items.AddRange(new object[] {
            "Available",
            "Occupied"});
            this.cBoxUAptFilterStatus.Location = new System.Drawing.Point(31, 42);
            this.cBoxUAptFilterStatus.Name = "cBoxUAptFilterStatus";
            this.cBoxUAptFilterStatus.Size = new System.Drawing.Size(233, 23);
            this.cBoxUAptFilterStatus.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select house status";
            // 
            // cb_UAptFilterStatus
            // 
            this.cb_UAptFilterStatus.AutoSize = true;
            this.cb_UAptFilterStatus.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_UAptFilterStatus.ForeColor = System.Drawing.Color.White;
            this.cb_UAptFilterStatus.Location = new System.Drawing.Point(20, 332);
            this.cb_UAptFilterStatus.Name = "cb_UAptFilterStatus";
            this.cb_UAptFilterStatus.Size = new System.Drawing.Size(72, 23);
            this.cb_UAptFilterStatus.TabIndex = 6;
            this.cb_UAptFilterStatus.Text = "Status";
            this.cb_UAptFilterStatus.UseVisualStyleBackColor = true;
            this.cb_UAptFilterStatus.CheckedChanged += new System.EventHandler(this.cb_UAptFilterStatus_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUAptFilterCont);
            this.panel4.Location = new System.Drawing.Point(0, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 60);
            this.panel4.TabIndex = 5;
            // 
            // txtUAptFilterCont
            // 
            this.txtUAptFilterCont.Enabled = false;
            this.txtUAptFilterCont.Location = new System.Drawing.Point(31, 19);
            this.txtUAptFilterCont.Name = "txtUAptFilterCont";
            this.txtUAptFilterCont.PlaceholderText = "Enter number of bedrooms";
            this.txtUAptFilterCont.Size = new System.Drawing.Size(234, 23);
            this.txtUAptFilterCont.TabIndex = 4;
            // 
            // cb_UAptFilterCont
            // 
            this.cb_UAptFilterCont.AutoSize = true;
            this.cb_UAptFilterCont.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_UAptFilterCont.ForeColor = System.Drawing.Color.White;
            this.cb_UAptFilterCont.Location = new System.Drawing.Point(20, 237);
            this.cb_UAptFilterCont.Name = "cb_UAptFilterCont";
            this.cb_UAptFilterCont.Size = new System.Drawing.Size(178, 23);
            this.cb_UAptFilterCont.TabIndex = 5;
            this.cb_UAptFilterCont.Text = "Number of Bedrooms";
            this.cb_UAptFilterCont.UseVisualStyleBackColor = true;
            this.cb_UAptFilterCont.CheckedChanged += new System.EventHandler(this.cb_UAptFilterCont_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUAptFilterCity);
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 67);
            this.panel3.TabIndex = 4;
            // 
            // txtUAptFilterCity
            // 
            this.txtUAptFilterCity.Enabled = false;
            this.txtUAptFilterCity.Location = new System.Drawing.Point(30, 23);
            this.txtUAptFilterCity.Name = "txtUAptFilterCity";
            this.txtUAptFilterCity.PlaceholderText = "Enter city name";
            this.txtUAptFilterCity.Size = new System.Drawing.Size(234, 23);
            this.txtUAptFilterCity.TabIndex = 3;
            // 
            // cb_UAptFilterCity
            // 
            this.cb_UAptFilterCity.AutoSize = true;
            this.cb_UAptFilterCity.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_UAptFilterCity.ForeColor = System.Drawing.Color.White;
            this.cb_UAptFilterCity.Location = new System.Drawing.Point(20, 135);
            this.cb_UAptFilterCity.Name = "cb_UAptFilterCity";
            this.cb_UAptFilterCity.Size = new System.Drawing.Size(56, 23);
            this.cb_UAptFilterCity.TabIndex = 2;
            this.cb_UAptFilterCity.Text = "City";
            this.cb_UAptFilterCity.UseVisualStyleBackColor = true;
            this.cb_UAptFilterCity.CheckedChanged += new System.EventHandler(this.cb_UAptFilterCity_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cBoxUAptFilterRegion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 90);
            this.panel2.TabIndex = 1;
            // 
            // cBoxUAptFilterRegion
            // 
            this.cBoxUAptFilterRegion.Enabled = false;
            this.cBoxUAptFilterRegion.FormattingEnabled = true;
            this.cBoxUAptFilterRegion.Items.AddRange(new object[] {
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
            this.cBoxUAptFilterRegion.Location = new System.Drawing.Point(31, 42);
            this.cBoxUAptFilterRegion.Name = "cBoxUAptFilterRegion";
            this.cBoxUAptFilterRegion.Size = new System.Drawing.Size(233, 23);
            this.cBoxUAptFilterRegion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a region";
            // 
            // cb_UAptFilterRegion
            // 
            this.cb_UAptFilterRegion.AutoSize = true;
            this.cb_UAptFilterRegion.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_UAptFilterRegion.ForeColor = System.Drawing.Color.White;
            this.cb_UAptFilterRegion.Location = new System.Drawing.Point(20, 10);
            this.cb_UAptFilterRegion.Name = "cb_UAptFilterRegion";
            this.cb_UAptFilterRegion.Size = new System.Drawing.Size(76, 23);
            this.cb_UAptFilterRegion.TabIndex = 0;
            this.cb_UAptFilterRegion.Text = "Region";
            this.cb_UAptFilterRegion.UseVisualStyleBackColor = true;
            this.cb_UAptFilterRegion.CheckedChanged += new System.EventHandler(this.cb_UAptFilterRegion_CheckedChanged);
            // 
            // uc_Apartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlUAptFilter);
            this.Controls.Add(this.dgv_Apartments);
            this.Controls.Add(this.btnUserAptFilter);
            this.Controls.Add(this.label1);
            this.Name = "uc_Apartments";
            this.Size = new System.Drawing.Size(1013, 562);
            this.Load += new System.EventHandler(this.uc_Apartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Apartments)).EndInit();
            this.pnlUAptFilter.ResumeLayout(false);
            this.pnlUAptFilter.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserAptFilter;
        private System.Windows.Forms.DataGridView dgv_Apartments;
        private System.Windows.Forms.Panel pnlUAptFilter;
        private System.Windows.Forms.CheckBox cb_UAptFilterRegion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxUAptFilterRegion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cBoxUAptFilterStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_UAptFilterStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cb_UAptFilterCont;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cb_UAptFilterCity;
        private System.Windows.Forms.TextBox txtUAptFilterCont;
        private System.Windows.Forms.TextBox txtUAptFilterCity;
        private System.Windows.Forms.Button btnUAptFilterCancle;
        private System.Windows.Forms.Button btnUAptFilterOk;
    }
}
