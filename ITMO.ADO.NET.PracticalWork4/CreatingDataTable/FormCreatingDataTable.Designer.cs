namespace CreatingDataTable
{
    partial class FormCreatingDataTable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonPopulateChildTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonFillInTheMainTable = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPopulateChildTable
            // 
            this.ButtonPopulateChildTable.Location = new System.Drawing.Point(12, 12);
            this.ButtonPopulateChildTable.Name = "ButtonPopulateChildTable";
            this.ButtonPopulateChildTable.Size = new System.Drawing.Size(150, 23);
            this.ButtonPopulateChildTable.TabIndex = 0;
            this.ButtonPopulateChildTable.Text = "Populate child table";
            this.ButtonPopulateChildTable.UseVisualStyleBackColor = true;
            this.ButtonPopulateChildTable.Click += new System.EventHandler(this.ButtonPopulateChildTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(150, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ButtonFillInTheMainTable
            // 
            this.ButtonFillInTheMainTable.Location = new System.Drawing.Point(168, 12);
            this.ButtonFillInTheMainTable.Name = "ButtonFillInTheMainTable";
            this.ButtonFillInTheMainTable.Size = new System.Drawing.Size(150, 23);
            this.ButtonFillInTheMainTable.TabIndex = 2;
            this.ButtonFillInTheMainTable.Text = "Fill in the main table";
            this.ButtonFillInTheMainTable.UseVisualStyleBackColor = true;
            this.ButtonFillInTheMainTable.Click += new System.EventHandler(this.ButtonFillInTheMainTable_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(168, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(150, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // FormCreatingDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 222);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ButtonFillInTheMainTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonPopulateChildTable);
            this.Name = "FormCreatingDataTable";
            this.Text = "CreatingDataTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPopulateChildTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonFillInTheMainTable;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

