
namespace REMS
{
    partial class uc_DeleteRentalShop
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
            this.btnDeleteRntSearch = new System.Windows.Forms.Button();
            this.txtDeleteRntIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Delete = new System.Windows.Forms.DataGridView();
            this.btnDeleteRntDelete = new System.Windows.Forms.Button();
            this.btnDeleteRntCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRntSearch
            // 
            this.btnDeleteRntSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteRntSearch.FlatAppearance.BorderSize = 0;
            this.btnDeleteRntSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRntSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRntSearch.Location = new System.Drawing.Point(576, 33);
            this.btnDeleteRntSearch.Name = "btnDeleteRntSearch";
            this.btnDeleteRntSearch.Size = new System.Drawing.Size(117, 28);
            this.btnDeleteRntSearch.TabIndex = 5;
            this.btnDeleteRntSearch.Text = "SEARCH";
            this.btnDeleteRntSearch.UseVisualStyleBackColor = false;
            this.btnDeleteRntSearch.Click += new System.EventHandler(this.btnDeleteRntSearch_Click);
            // 
            // txtDeleteRntIDSearch
            // 
            this.txtDeleteRntIDSearch.Location = new System.Drawing.Point(389, 36);
            this.txtDeleteRntIDSearch.Name = "txtDeleteRntIDSearch";
            this.txtDeleteRntIDSearch.PlaceholderText = "Rental shop ID";
            this.txtDeleteRntIDSearch.Size = new System.Drawing.Size(100, 23);
            this.txtDeleteRntIDSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Rental Shop ID";
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete.Location = new System.Drawing.Point(0, 101);
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.RowTemplate.Height = 25;
            this.dgv_Delete.Size = new System.Drawing.Size(952, 158);
            this.dgv_Delete.TabIndex = 6;
            // 
            // btnDeleteRntDelete
            // 
            this.btnDeleteRntDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteRntDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRntDelete.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRntDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRntDelete.Location = new System.Drawing.Point(601, 336);
            this.btnDeleteRntDelete.Name = "btnDeleteRntDelete";
            this.btnDeleteRntDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteRntDelete.TabIndex = 23;
            this.btnDeleteRntDelete.Text = "DELETE";
            this.btnDeleteRntDelete.UseVisualStyleBackColor = false;
            this.btnDeleteRntDelete.Click += new System.EventHandler(this.btnDeleteRntDelete_Click);
            // 
            // btnDeleteRntCancel
            // 
            this.btnDeleteRntCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRntCancel.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRntCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteRntCancel.Location = new System.Drawing.Point(249, 336);
            this.btnDeleteRntCancel.Name = "btnDeleteRntCancel";
            this.btnDeleteRntCancel.Size = new System.Drawing.Size(125, 35);
            this.btnDeleteRntCancel.TabIndex = 22;
            this.btnDeleteRntCancel.Text = "CANCEL";
            this.btnDeleteRntCancel.UseVisualStyleBackColor = true;
            this.btnDeleteRntCancel.Click += new System.EventHandler(this.btnDeleteRntCancel_Click);
            // 
            // uc_DeleteRentalShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnDeleteRntDelete);
            this.Controls.Add(this.btnDeleteRntCancel);
            this.Controls.Add(this.dgv_Delete);
            this.Controls.Add(this.btnDeleteRntSearch);
            this.Controls.Add(this.txtDeleteRntIDSearch);
            this.Controls.Add(this.label1);
            this.Name = "uc_DeleteRentalShop";
            this.Size = new System.Drawing.Size(952, 429);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRntSearch;
        private System.Windows.Forms.TextBox txtDeleteRntIDSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Delete;
        private System.Windows.Forms.Button btnDeleteRntDelete;
        private System.Windows.Forms.Button btnDeleteRntCancel;
    }
}
