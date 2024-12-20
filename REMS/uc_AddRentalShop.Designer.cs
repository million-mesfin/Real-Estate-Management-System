
namespace REMS
{
    partial class uc_AddRentalShop
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
            this.cBoxAddRentalRegion = new System.Windows.Forms.ComboBox();
            this.txtAddRentalFloorSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddRentalCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRentalClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddRentalValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddRentalStories = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddRentalConId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxAddRentalStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddRentalAdd = new System.Windows.Forms.Button();
            this.txtAddRentalBuiltOn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBoxAddRentalRegion
            // 
            this.cBoxAddRentalRegion.FormattingEnabled = true;
            this.cBoxAddRentalRegion.Items.AddRange(new object[] {
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
            this.cBoxAddRentalRegion.Location = new System.Drawing.Point(129, 52);
            this.cBoxAddRentalRegion.Name = "cBoxAddRentalRegion";
            this.cBoxAddRentalRegion.Size = new System.Drawing.Size(200, 23);
            this.cBoxAddRentalRegion.TabIndex = 0;
            // 
            // txtAddRentalFloorSpace
            // 
            this.txtAddRentalFloorSpace.Location = new System.Drawing.Point(593, 52);
            this.txtAddRentalFloorSpace.Name = "txtAddRentalFloorSpace";
            this.txtAddRentalFloorSpace.PlaceholderText = "Floor space (in meter square)";
            this.txtAddRentalFloorSpace.Size = new System.Drawing.Size(200, 23);
            this.txtAddRentalFloorSpace.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a region";
            // 
            // txtAddRentalCity
            // 
            this.txtAddRentalCity.Location = new System.Drawing.Point(129, 126);
            this.txtAddRentalCity.Name = "txtAddRentalCity";
            this.txtAddRentalCity.PlaceholderText = "City name";
            this.txtAddRentalCity.Size = new System.Drawing.Size(200, 23);
            this.txtAddRentalCity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(129, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter City";
            // 
            // btnAddRentalClear
            // 
            this.btnAddRentalClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRentalClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRentalClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAddRentalClear.Location = new System.Drawing.Point(229, 345);
            this.btnAddRentalClear.Name = "btnAddRentalClear";
            this.btnAddRentalClear.Size = new System.Drawing.Size(100, 40);
            this.btnAddRentalClear.TabIndex = 5;
            this.btnAddRentalClear.Text = "CLEAR";
            this.btnAddRentalClear.UseVisualStyleBackColor = true;
            this.btnAddRentalClear.Click += new System.EventHandler(this.btnAddRentalClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Rent Value";
            // 
            // txtAddRentalValue
            // 
            this.txtAddRentalValue.Location = new System.Drawing.Point(129, 200);
            this.txtAddRentalValue.Name = "txtAddRentalValue";
            this.txtAddRentalValue.PlaceholderText = "Rent value";
            this.txtAddRentalValue.Size = new System.Drawing.Size(200, 23);
            this.txtAddRentalValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Number Of Stories";
            // 
            // txtAddRentalStories
            // 
            this.txtAddRentalStories.Location = new System.Drawing.Point(129, 274);
            this.txtAddRentalStories.Name = "txtAddRentalStories";
            this.txtAddRentalStories.PlaceholderText = "Number of stories";
            this.txtAddRentalStories.Size = new System.Drawing.Size(200, 23);
            this.txtAddRentalStories.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(593, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Floor Space";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(593, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter Contractor ID";
            // 
            // txtAddRentalConId
            // 
            this.txtAddRentalConId.Location = new System.Drawing.Point(593, 126);
            this.txtAddRentalConId.Name = "txtAddRentalConId";
            this.txtAddRentalConId.PlaceholderText = "Contractor ID";
            this.txtAddRentalConId.Size = new System.Drawing.Size(200, 23);
            this.txtAddRentalConId.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(593, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Select Build Finish Date";
            // 
            // cBoxAddRentalStatus
            // 
            this.cBoxAddRentalStatus.FormattingEnabled = true;
            this.cBoxAddRentalStatus.Items.AddRange(new object[] {
            "Available",
            "Occupied"});
            this.cBoxAddRentalStatus.Location = new System.Drawing.Point(593, 274);
            this.cBoxAddRentalStatus.Name = "cBoxAddRentalStatus";
            this.cBoxAddRentalStatus.Size = new System.Drawing.Size(200, 23);
            this.cBoxAddRentalStatus.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(593, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Select House Status";
            // 
            // btnAddRentalAdd
            // 
            this.btnAddRentalAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAddRentalAdd.FlatAppearance.BorderSize = 0;
            this.btnAddRentalAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRentalAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRentalAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAddRentalAdd.Location = new System.Drawing.Point(593, 345);
            this.btnAddRentalAdd.Name = "btnAddRentalAdd";
            this.btnAddRentalAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAddRentalAdd.TabIndex = 18;
            this.btnAddRentalAdd.Text = "ADD";
            this.btnAddRentalAdd.UseVisualStyleBackColor = false;
            this.btnAddRentalAdd.Click += new System.EventHandler(this.btnAddRentalAdd_Click);
            // 
            // txtAddRentalBuiltOn
            // 
            this.txtAddRentalBuiltOn.Location = new System.Drawing.Point(593, 200);
            this.txtAddRentalBuiltOn.Name = "txtAddRentalBuiltOn";
            this.txtAddRentalBuiltOn.PlaceholderText = "YEAR -  MONTH - DATE";
            this.txtAddRentalBuiltOn.Size = new System.Drawing.Size(200, 23);
            this.txtAddRentalBuiltOn.TabIndex = 19;
            // 
            // uc_AddRentalShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.txtAddRentalBuiltOn);
            this.Controls.Add(this.btnAddRentalAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBoxAddRentalStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddRentalConId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddRentalStories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddRentalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddRentalClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddRentalCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddRentalFloorSpace);
            this.Controls.Add(this.cBoxAddRentalRegion);
            this.Name = "uc_AddRentalShop";
            this.Size = new System.Drawing.Size(952, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxAddRentalRegion;
        private System.Windows.Forms.TextBox txtAddRentalFloorSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddRentalCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRentalClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddRentalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddRentalStories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddRentalConId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxAddRentalStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddRentalAdd;
        private System.Windows.Forms.TextBox txtAddRentalBuiltOn;
    }
}
