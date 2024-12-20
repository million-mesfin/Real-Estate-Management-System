
namespace REMS
{
    partial class uc_HousesAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdminModHouse = new System.Windows.Forms.Panel();
            this.btnDeleteHouse = new System.Windows.Forms.Button();
            this.btnEditHouseInfo = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnAdminModifyHouse = new System.Windows.Forms.Button();
            this.btnAdminSplitLevel = new System.Windows.Forms.Button();
            this.btnAdminApartment = new System.Windows.Forms.Button();
            this.btnAdminRental = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAdminHouseContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlAdminModHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pnlAdminModHouse);
            this.panel1.Controls.Add(this.btnAdminModifyHouse);
            this.panel1.Controls.Add(this.btnAdminSplitLevel);
            this.panel1.Controls.Add(this.btnAdminApartment);
            this.panel1.Controls.Add(this.btnAdminRental);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // pnlAdminModHouse
            // 
            this.pnlAdminModHouse.Controls.Add(this.btnDeleteHouse);
            this.pnlAdminModHouse.Controls.Add(this.btnEditHouseInfo);
            this.pnlAdminModHouse.Controls.Add(this.btnAddHouse);
            this.pnlAdminModHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminModHouse.Location = new System.Drawing.Point(0, 330);
            this.pnlAdminModHouse.Name = "pnlAdminModHouse";
            this.pnlAdminModHouse.Size = new System.Drawing.Size(200, 114);
            this.pnlAdminModHouse.TabIndex = 7;
            this.pnlAdminModHouse.Visible = false;
            // 
            // btnDeleteHouse
            // 
            this.btnDeleteHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteHouse.FlatAppearance.BorderSize = 0;
            this.btnDeleteHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteHouse.Location = new System.Drawing.Point(0, 70);
            this.btnDeleteHouse.Name = "btnDeleteHouse";
            this.btnDeleteHouse.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDeleteHouse.Size = new System.Drawing.Size(200, 35);
            this.btnDeleteHouse.TabIndex = 2;
            this.btnDeleteHouse.Text = "Delete House";
            this.btnDeleteHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteHouse.UseVisualStyleBackColor = true;
            this.btnDeleteHouse.Click += new System.EventHandler(this.btnDeleteHouse_Click);
            // 
            // btnEditHouseInfo
            // 
            this.btnEditHouseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditHouseInfo.FlatAppearance.BorderSize = 0;
            this.btnEditHouseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHouseInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditHouseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnEditHouseInfo.Location = new System.Drawing.Point(0, 35);
            this.btnEditHouseInfo.Name = "btnEditHouseInfo";
            this.btnEditHouseInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEditHouseInfo.Size = new System.Drawing.Size(200, 35);
            this.btnEditHouseInfo.TabIndex = 1;
            this.btnEditHouseInfo.Text = "Edit House Info";
            this.btnEditHouseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditHouseInfo.UseVisualStyleBackColor = true;
            this.btnEditHouseInfo.Click += new System.EventHandler(this.btnEditHouseInfo_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddHouse.FlatAppearance.BorderSize = 0;
            this.btnAddHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAddHouse.Location = new System.Drawing.Point(0, 0);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddHouse.Size = new System.Drawing.Size(200, 35);
            this.btnAddHouse.TabIndex = 0;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminModifyHouse
            // 
            this.btnAdminModifyHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAdminModifyHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminModifyHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminModifyHouse.FlatAppearance.BorderSize = 0;
            this.btnAdminModifyHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminModifyHouse.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminModifyHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAdminModifyHouse.Location = new System.Drawing.Point(0, 285);
            this.btnAdminModifyHouse.Name = "btnAdminModifyHouse";
            this.btnAdminModifyHouse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdminModifyHouse.Size = new System.Drawing.Size(200, 45);
            this.btnAdminModifyHouse.TabIndex = 6;
            this.btnAdminModifyHouse.Text = "Modify House";
            this.btnAdminModifyHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminModifyHouse.UseVisualStyleBackColor = false;
            this.btnAdminModifyHouse.Click += new System.EventHandler(this.btnAdminModifyHouse_Click);
            // 
            // btnAdminSplitLevel
            // 
            this.btnAdminSplitLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAdminSplitLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminSplitLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminSplitLevel.FlatAppearance.BorderSize = 0;
            this.btnAdminSplitLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSplitLevel.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminSplitLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAdminSplitLevel.Location = new System.Drawing.Point(0, 240);
            this.btnAdminSplitLevel.Name = "btnAdminSplitLevel";
            this.btnAdminSplitLevel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdminSplitLevel.Size = new System.Drawing.Size(200, 45);
            this.btnAdminSplitLevel.TabIndex = 4;
            this.btnAdminSplitLevel.Text = "Split-Level";
            this.btnAdminSplitLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminSplitLevel.UseVisualStyleBackColor = false;
            this.btnAdminSplitLevel.Click += new System.EventHandler(this.btnAdminSplitLevel_Click);
            // 
            // btnAdminApartment
            // 
            this.btnAdminApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAdminApartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminApartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminApartment.FlatAppearance.BorderSize = 0;
            this.btnAdminApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminApartment.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminApartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAdminApartment.Location = new System.Drawing.Point(0, 195);
            this.btnAdminApartment.Name = "btnAdminApartment";
            this.btnAdminApartment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdminApartment.Size = new System.Drawing.Size(200, 45);
            this.btnAdminApartment.TabIndex = 3;
            this.btnAdminApartment.Text = "Apartments";
            this.btnAdminApartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminApartment.UseVisualStyleBackColor = false;
            this.btnAdminApartment.Click += new System.EventHandler(this.btnAdminApartment_Click);
            // 
            // btnAdminRental
            // 
            this.btnAdminRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAdminRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminRental.FlatAppearance.BorderSize = 0;
            this.btnAdminRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRental.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnAdminRental.Location = new System.Drawing.Point(0, 150);
            this.btnAdminRental.Name = "btnAdminRental";
            this.btnAdminRental.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdminRental.Size = new System.Drawing.Size(200, 45);
            this.btnAdminRental.TabIndex = 2;
            this.btnAdminRental.Text = "Rental Shops";
            this.btnAdminRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminRental.UseVisualStyleBackColor = false;
            this.btnAdminRental.Click += new System.EventHandler(this.btnAdminRental_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 0;
            // 
            // pnlAdminHouseContainer
            // 
            this.pnlAdminHouseContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlAdminHouseContainer.Location = new System.Drawing.Point(207, 0);
            this.pnlAdminHouseContainer.Name = "pnlAdminHouseContainer";
            this.pnlAdminHouseContainer.Size = new System.Drawing.Size(1013, 563);
            this.pnlAdminHouseContainer.TabIndex = 2;
            // 
            // uc_HousesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlAdminHouseContainer);
            this.Controls.Add(this.panel1);
            this.Name = "uc_HousesAdmin";
            this.Size = new System.Drawing.Size(1220, 563);
            this.Load += new System.EventHandler(this.uc_HousesAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.pnlAdminModHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAdminModHouse;
        private System.Windows.Forms.Button btnDeleteHouse;
        private System.Windows.Forms.Button btnEditHouseInfo;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnAdminModifyHouse;
        private System.Windows.Forms.Button btnAdminSplitLevel;
        private System.Windows.Forms.Button btnAdminApartment;
        private System.Windows.Forms.Button btnAdminRental;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAdminHouseContainer;
    }
}
