
namespace REMS
{
    partial class uc_AddClearLot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddClearLotSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtAddClearLotCity = new System.Windows.Forms.Label();
            this.cBoxAddClearLotRegion = new System.Windows.Forms.ComboBox();
            this.cBoxAddClearLotPermit = new System.Windows.Forms.ComboBox();
            this.btnAddClearLotAdd = new System.Windows.Forms.Button();
            this.btnAddClearLotClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Clear Lots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            // 
            // txtAddClearLotSize
            // 
            this.txtAddClearLotSize.Location = new System.Drawing.Point(199, 137);
            this.txtAddClearLotSize.Name = "txtAddClearLotSize";
            this.txtAddClearLotSize.PlaceholderText = "Enter Lot Size";
            this.txtAddClearLotSize.Size = new System.Drawing.Size(200, 23);
            this.txtAddClearLotSize.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(480, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Permit Status";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(642, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Enter Lot Size";
            this.textBox4.Size = new System.Drawing.Size(200, 23);
            this.textBox4.TabIndex = 12;
            // 
            // txtAddClearLotCity
            // 
            this.txtAddClearLotCity.AutoSize = true;
            this.txtAddClearLotCity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddClearLotCity.ForeColor = System.Drawing.Color.White;
            this.txtAddClearLotCity.Location = new System.Drawing.Point(541, 136);
            this.txtAddClearLotCity.Name = "txtAddClearLotCity";
            this.txtAddClearLotCity.Size = new System.Drawing.Size(34, 20);
            this.txtAddClearLotCity.TabIndex = 11;
            this.txtAddClearLotCity.Text = "City";
            // 
            // cBoxAddClearLotRegion
            // 
            this.cBoxAddClearLotRegion.FormattingEnabled = true;
            this.cBoxAddClearLotRegion.Items.AddRange(new object[] {
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
            this.cBoxAddClearLotRegion.Location = new System.Drawing.Point(199, 228);
            this.cBoxAddClearLotRegion.Name = "cBoxAddClearLotRegion";
            this.cBoxAddClearLotRegion.Size = new System.Drawing.Size(200, 23);
            this.cBoxAddClearLotRegion.TabIndex = 13;
            // 
            // cBoxAddClearLotPermit
            // 
            this.cBoxAddClearLotPermit.FormattingEnabled = true;
            this.cBoxAddClearLotPermit.Items.AddRange(new object[] {
            "Active",
            "Pending",
            "On Hold"});
            this.cBoxAddClearLotPermit.Location = new System.Drawing.Point(642, 228);
            this.cBoxAddClearLotPermit.Name = "cBoxAddClearLotPermit";
            this.cBoxAddClearLotPermit.Size = new System.Drawing.Size(200, 23);
            this.cBoxAddClearLotPermit.TabIndex = 14;
            // 
            // btnAddClearLotAdd
            // 
            this.btnAddClearLotAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAddClearLotAdd.FlatAppearance.BorderSize = 0;
            this.btnAddClearLotAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClearLotAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddClearLotAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAddClearLotAdd.Location = new System.Drawing.Point(599, 422);
            this.btnAddClearLotAdd.Name = "btnAddClearLotAdd";
            this.btnAddClearLotAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAddClearLotAdd.TabIndex = 20;
            this.btnAddClearLotAdd.Text = "ADD";
            this.btnAddClearLotAdd.UseVisualStyleBackColor = false;
            this.btnAddClearLotAdd.Click += new System.EventHandler(this.btnAddClearLotAdd_Click);
            // 
            // btnAddClearLotClear
            // 
            this.btnAddClearLotClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClearLotClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddClearLotClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAddClearLotClear.Location = new System.Drawing.Point(235, 422);
            this.btnAddClearLotClear.Name = "btnAddClearLotClear";
            this.btnAddClearLotClear.Size = new System.Drawing.Size(100, 40);
            this.btnAddClearLotClear.TabIndex = 19;
            this.btnAddClearLotClear.Text = "CLEAR";
            this.btnAddClearLotClear.UseVisualStyleBackColor = true;
            this.btnAddClearLotClear.Click += new System.EventHandler(this.btnAddRentalClear_Click);
            // 
            // uc_AddClearLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnAddClearLotAdd);
            this.Controls.Add(this.btnAddClearLotClear);
            this.Controls.Add(this.cBoxAddClearLotPermit);
            this.Controls.Add(this.cBoxAddClearLotRegion);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAddClearLotCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddClearLotSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_AddClearLot";
            this.Size = new System.Drawing.Size(1014, 563);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddClearLotSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtAddClearLotCity;
        private System.Windows.Forms.ComboBox cBoxAddClearLotRegion;
        private System.Windows.Forms.ComboBox cBoxAddClearLotPermit;
        private System.Windows.Forms.Button btnAddClearLotAdd;
        private System.Windows.Forms.Button btnAddClearLotClear;
    }
}
