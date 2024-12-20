
namespace REMS
{
    partial class uc_EditHouse
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
            this.cBoxEditHouseType = new System.Windows.Forms.ComboBox();
            this.pnlEditContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select House Type";
            // 
            // cBoxEditHouseType
            // 
            this.cBoxEditHouseType.FormattingEnabled = true;
            this.cBoxEditHouseType.Items.AddRange(new object[] {
            "Rental Shop",
            "Apartment",
            "Split-Level"});
            this.cBoxEditHouseType.Location = new System.Drawing.Point(214, 72);
            this.cBoxEditHouseType.Name = "cBoxEditHouseType";
            this.cBoxEditHouseType.Size = new System.Drawing.Size(200, 23);
            this.cBoxEditHouseType.TabIndex = 3;
            this.cBoxEditHouseType.SelectedIndexChanged += new System.EventHandler(this.cBoxEditHouseType_SelectedIndexChanged);
            // 
            // pnlEditContainer
            // 
            this.pnlEditContainer.Location = new System.Drawing.Point(30, 133);
            this.pnlEditContainer.Name = "pnlEditContainer";
            this.pnlEditContainer.Size = new System.Drawing.Size(952, 429);
            this.pnlEditContainer.TabIndex = 5;
            // 
            // uc_EditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlEditContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxEditHouseType);
            this.Controls.Add(this.label1);
            this.Name = "uc_EditHouse";
            this.Size = new System.Drawing.Size(1013, 563);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxEditHouseType;
        private System.Windows.Forms.Panel pnlEditContainer;
    }
}
