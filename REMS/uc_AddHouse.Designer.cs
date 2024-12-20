
namespace REMS
{
    partial class uc_AddHouse
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
            this.cBoxAddHouseType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add House";
            // 
            // cBoxAddHouseType
            // 
            this.cBoxAddHouseType.FormattingEnabled = true;
            this.cBoxAddHouseType.Items.AddRange(new object[] {
            "Rental Shop",
            "Apartment",
            "Split-Level"});
            this.cBoxAddHouseType.Location = new System.Drawing.Point(214, 72);
            this.cBoxAddHouseType.Name = "cBoxAddHouseType";
            this.cBoxAddHouseType.Size = new System.Drawing.Size(200, 23);
            this.cBoxAddHouseType.TabIndex = 1;
            this.cBoxAddHouseType.SelectedIndexChanged += new System.EventHandler(this.cBoxAddHouseType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select House Type";
            // 
            // pnlAddContainer
            // 
            this.pnlAddContainer.Location = new System.Drawing.Point(30, 133);
            this.pnlAddContainer.Name = "pnlAddContainer";
            this.pnlAddContainer.Size = new System.Drawing.Size(952, 429);
            this.pnlAddContainer.TabIndex = 3;
            // 
            // uc_AddHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlAddContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxAddHouseType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "uc_AddHouse";
            this.Size = new System.Drawing.Size(1013, 563);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxAddHouseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAddContainer;
    }
}
