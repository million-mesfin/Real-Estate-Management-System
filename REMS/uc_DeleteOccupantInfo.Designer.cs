
namespace REMS
{
    partial class uc_DeleteOccupantInfo
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
            this.btnDeleteOccupantSearch = new System.Windows.Forms.Button();
            this.txtDeleteOccupantIDSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Delete = new System.Windows.Forms.DataGridView();
            this.btnDeleteOccDelete = new System.Windows.Forms.Button();
            this.btnDeleteOccCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delete Occupant Information";
            // 
            // btnDeleteOccupantSearch
            // 
            this.btnDeleteOccupantSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteOccupantSearch.FlatAppearance.BorderSize = 0;
            this.btnDeleteOccupantSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOccupantSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOccupantSearch.Location = new System.Drawing.Point(577, 96);
            this.btnDeleteOccupantSearch.Name = "btnDeleteOccupantSearch";
            this.btnDeleteOccupantSearch.Size = new System.Drawing.Size(117, 28);
            this.btnDeleteOccupantSearch.TabIndex = 10;
            this.btnDeleteOccupantSearch.Text = "SEARCH";
            this.btnDeleteOccupantSearch.UseVisualStyleBackColor = false;
            this.btnDeleteOccupantSearch.Click += new System.EventHandler(this.btnDeleteOccupantSearch_Click);
            // 
            // txtDeleteOccupantIDSearch
            // 
            this.txtDeleteOccupantIDSearch.Location = new System.Drawing.Point(390, 99);
            this.txtDeleteOccupantIDSearch.Name = "txtDeleteOccupantIDSearch";
            this.txtDeleteOccupantIDSearch.PlaceholderText = "Occupant ID";
            this.txtDeleteOccupantIDSearch.Size = new System.Drawing.Size(100, 23);
            this.txtDeleteOccupantIDSearch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Occupant ID";
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete.Location = new System.Drawing.Point(3, 185);
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.RowTemplate.Height = 25;
            this.dgv_Delete.Size = new System.Drawing.Size(952, 158);
            this.dgv_Delete.TabIndex = 11;
            // 
            // btnDeleteOccDelete
            // 
            this.btnDeleteOccDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteOccDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOccDelete.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOccDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteOccDelete.Location = new System.Drawing.Point(569, 444);
            this.btnDeleteOccDelete.Name = "btnDeleteOccDelete";
            this.btnDeleteOccDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteOccDelete.TabIndex = 25;
            this.btnDeleteOccDelete.Text = "DELETE";
            this.btnDeleteOccDelete.UseVisualStyleBackColor = false;
            this.btnDeleteOccDelete.Click += new System.EventHandler(this.btnDeleteOccDelete_Click);
            // 
            // btnDeleteOccCancel
            // 
            this.btnDeleteOccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOccCancel.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOccCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteOccCancel.Location = new System.Drawing.Point(217, 444);
            this.btnDeleteOccCancel.Name = "btnDeleteOccCancel";
            this.btnDeleteOccCancel.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteOccCancel.TabIndex = 24;
            this.btnDeleteOccCancel.Text = "CANCEL";
            this.btnDeleteOccCancel.UseVisualStyleBackColor = true;
            this.btnDeleteOccCancel.Click += new System.EventHandler(this.btnDeleteOccCancel_Click);
            // 
            // uc_DeleteOccupantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnDeleteOccDelete);
            this.Controls.Add(this.btnDeleteOccCancel);
            this.Controls.Add(this.dgv_Delete);
            this.Controls.Add(this.btnDeleteOccupantSearch);
            this.Controls.Add(this.txtDeleteOccupantIDSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_DeleteOccupantInfo";
            this.Size = new System.Drawing.Size(1014, 563);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteOccupantSearch;
        private System.Windows.Forms.TextBox txtDeleteOccupantIDSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Delete;
        private System.Windows.Forms.Button btnDeleteOccDelete;
        private System.Windows.Forms.Button btnDeleteOccCancel;
    }
}
