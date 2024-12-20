
namespace REMS
{
    partial class uc_DeleteSoldInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSldSearch = new System.Windows.Forms.Button();
            this.txtDeleteSldIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteSldDelete = new System.Windows.Forms.Button();
            this.btnDeleteSldCancel = new System.Windows.Forms.Button();
            this.dgv_Delete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Delete Occupied Houses";
            // 
            // btnDeleteSldSearch
            // 
            this.btnDeleteSldSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteSldSearch.FlatAppearance.BorderSize = 0;
            this.btnDeleteSldSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSldSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSldSearch.Location = new System.Drawing.Point(628, 102);
            this.btnDeleteSldSearch.Name = "btnDeleteSldSearch";
            this.btnDeleteSldSearch.Size = new System.Drawing.Size(117, 28);
            this.btnDeleteSldSearch.TabIndex = 8;
            this.btnDeleteSldSearch.Text = "SEARCH";
            this.btnDeleteSldSearch.UseVisualStyleBackColor = false;
            // 
            // txtDeleteSldIDSearch
            // 
            this.txtDeleteSldIDSearch.Location = new System.Drawing.Point(441, 105);
            this.txtDeleteSldIDSearch.Name = "txtDeleteSldIDSearch";
            this.txtDeleteSldIDSearch.Size = new System.Drawing.Size(100, 23);
            this.txtDeleteSldIDSearch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Occupied House ID";
            // 
            // btnDeleteSldDelete
            // 
            this.btnDeleteSldDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteSldDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSldDelete.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSldDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSldDelete.Location = new System.Drawing.Point(601, 424);
            this.btnDeleteSldDelete.Name = "btnDeleteSldDelete";
            this.btnDeleteSldDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteSldDelete.TabIndex = 26;
            this.btnDeleteSldDelete.Text = "DELETE";
            this.btnDeleteSldDelete.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSldCancel
            // 
            this.btnDeleteSldCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSldCancel.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSldCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteSldCancel.Location = new System.Drawing.Point(249, 424);
            this.btnDeleteSldCancel.Name = "btnDeleteSldCancel";
            this.btnDeleteSldCancel.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteSldCancel.TabIndex = 25;
            this.btnDeleteSldCancel.Text = "CANCEL";
            this.btnDeleteSldCancel.UseVisualStyleBackColor = true;
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete.Location = new System.Drawing.Point(0, 189);
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.RowTemplate.Height = 25;
            this.dgv_Delete.Size = new System.Drawing.Size(952, 158);
            this.dgv_Delete.TabIndex = 24;
            // 
            // uc_DeleteSoldInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnDeleteSldDelete);
            this.Controls.Add(this.btnDeleteSldCancel);
            this.Controls.Add(this.dgv_Delete);
            this.Controls.Add(this.btnDeleteSldSearch);
            this.Controls.Add(this.txtDeleteSldIDSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "uc_DeleteSoldInfo";
            this.Size = new System.Drawing.Size(1018, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSldSearch;
        private System.Windows.Forms.TextBox txtDeleteSldIDSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteSldDelete;
        private System.Windows.Forms.Button btnDeleteSldCancel;
        private System.Windows.Forms.DataGridView dgv_Delete;
    }
}
