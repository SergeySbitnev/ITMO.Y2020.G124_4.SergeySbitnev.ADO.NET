namespace DatasetDesigner
{
    partial class FormDatasetDesigner
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
            this.ButtonGetCustomers = new System.Windows.Forms.Button();
            this.ListBoxCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonGetCustomers
            // 
            this.ButtonGetCustomers.Location = new System.Drawing.Point(12, 12);
            this.ButtonGetCustomers.Name = "ButtonGetCustomers";
            this.ButtonGetCustomers.Size = new System.Drawing.Size(85, 23);
            this.ButtonGetCustomers.TabIndex = 0;
            this.ButtonGetCustomers.Text = "Get Customers";
            this.ButtonGetCustomers.UseVisualStyleBackColor = true;
            this.ButtonGetCustomers.Click += new System.EventHandler(this.ButtonGetCustomers_Click);
            // 
            // ListBoxCustomers
            // 
            this.ListBoxCustomers.FormattingEnabled = true;
            this.ListBoxCustomers.Location = new System.Drawing.Point(103, 12);
            this.ListBoxCustomers.Name = "ListBoxCustomers";
            this.ListBoxCustomers.Size = new System.Drawing.Size(200, 238);
            this.ListBoxCustomers.TabIndex = 1;
            // 
            // FormDatasetDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 541);
            this.Controls.Add(this.ListBoxCustomers);
            this.Controls.Add(this.ButtonGetCustomers);
            this.Name = "FormDatasetDesigner";
            this.Text = "DatasetDesigner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGetCustomers;
        private System.Windows.Forms.ListBox ListBoxCustomers;
    }
}

