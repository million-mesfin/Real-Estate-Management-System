
namespace REMS
{
    partial class uc_DeleteClearLot
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
            this.dgv_Delete = new System.Windows.Forms.DataGridView();
            this.btnDeleteClearLotDelete = new System.Windows.Forms.Button();
            this.btnDeleteClearLotClear = new System.Windows.Forms.Button();
            this.btnDeleteClearLotSearch = new System.Windows.Forms.Button();
            this.txtDeleteClearLotIDSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delete Clear Lots";
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgv_Delete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete.Location = new System.Drawing.Point(3, 176);
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.RowTemplate.Height = 25;
            this.dgv_Delete.Size = new System.Drawing.Size(1014, 166);
            this.dgv_Delete.TabIndex = 6;
            // 
            // btnDeleteClearLotDelete
            // 
            this.btnDeleteClearLotDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteClearLotDelete.FlatAppearance.BorderSize = 0;
            this.btnDeleteClearLotDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClearLotDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClearLotDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClearLotDelete.Location = new System.Drawing.Point(619, 456);
            this.btnDeleteClearLotDelete.Name = "btnDeleteClearLotDelete";
            this.btnDeleteClearLotDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteClearLotDelete.TabIndex = 22;
            this.btnDeleteClearLotDelete.Text = "DELETE";
            this.btnDeleteClearLotDelete.UseVisualStyleBackColor = false;
            this.btnDeleteClearLotDelete.Click += new System.EventHandler(this.btnDeleteClearLotDelete_Click);
            // 
            // btnDeleteClearLotClear
            // 
            this.btnDeleteClearLotClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClearLotClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClearLotClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteClearLotClear.Location = new System.Drawing.Point(255, 456);
            this.btnDeleteClearLotClear.Name = "btnDeleteClearLotClear";
            this.btnDeleteClearLotClear.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteClearLotClear.TabIndex = 21;
            this.btnDeleteClearLotClear.Text = "CLEAR";
            this.btnDeleteClearLotClear.UseVisualStyleBackColor = true;
            this.btnDeleteClearLotClear.Click += new System.EventHandler(this.btnDeleteClearLotClear_Click);
            // 
            // btnDeleteClearLotSearch
            // 
            this.btnDeleteClearLotSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.btnDeleteClearLotSearch.FlatAppearance.BorderSize = 0;
            this.btnDeleteClearLotSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClearLotSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClearLotSearch.Location = new System.Drawing.Point(600, 90);
            this.btnDeleteClearLotSearch.Name = "btnDeleteClearLotSearch";
            this.btnDeleteClearLotSearch.Size = new System.Drawing.Size(117, 28);
            this.btnDeleteClearLotSearch.TabIndex = 25;
            this.btnDeleteClearLotSearch.Text = "SEARCH";
            this.btnDeleteClearLotSearch.UseVisualStyleBackColor = false;
            this.btnDeleteClearLotSearch.Click += new System.EventHandler(this.btnDeleteClearLotSearch_Click);
            // 
            // txtDeleteClearLotIDSearch
            // 
            this.txtDeleteClearLotIDSearch.Location = new System.Drawing.Point(413, 93);
            this.txtDeleteClearLotIDSearch.Name = "txtDeleteClearLotIDSearch";
            this.txtDeleteClearLotIDSearch.PlaceholderText = "Clear lot ID";
            this.txtDeleteClearLotIDSearch.Size = new System.Drawing.Size(100, 23);
            this.txtDeleteClearLotIDSearch.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter Clear Lot ID";
            // 
            // uc_DeleteClearLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnDeleteClearLotSearch);
            this.Controls.Add(this.txtDeleteClearLotIDSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteClearLotDelete);
            this.Controls.Add(this.btnDeleteClearLotClear);
            this.Controls.Add(this.dgv_Delete);
            this.Controls.Add(this.label1);
            this.Name = "uc_DeleteClearLot";
            this.Size = new System.Drawing.Size(1014, 563);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Delete;
        private System.Windows.Forms.Button btnDeleteClearLotDelete;
        private System.Windows.Forms.Button btnDeleteClearLotClear;
        private System.Windows.Forms.Button btnDeleteClearLotSearch;
        private System.Windows.Forms.TextBox txtDeleteClearLotIDSearch;
        private System.Windows.Forms.Label label2;
    }
}
