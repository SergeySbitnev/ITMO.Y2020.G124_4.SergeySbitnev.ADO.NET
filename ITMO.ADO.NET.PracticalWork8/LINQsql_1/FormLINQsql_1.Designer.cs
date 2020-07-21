namespace LINQsql_1
{
    partial class FormLINQsql_1
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
            this.ButtonLoadingData = new System.Windows.Forms.Button();
            this.ButtonClearTheList = new System.Windows.Forms.Button();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.ButtonDeleteObject = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLoadingData
            // 
            this.ButtonLoadingData.Location = new System.Drawing.Point(12, 12);
            this.ButtonLoadingData.Name = "ButtonLoadingData";
            this.ButtonLoadingData.Size = new System.Drawing.Size(112, 23);
            this.ButtonLoadingData.TabIndex = 0;
            this.ButtonLoadingData.Text = "Loading data";
            this.ButtonLoadingData.UseVisualStyleBackColor = true;
            this.ButtonLoadingData.Click += new System.EventHandler(this.ButtonLoadingData_Click);
            // 
            // ButtonClearTheList
            // 
            this.ButtonClearTheList.Location = new System.Drawing.Point(12, 41);
            this.ButtonClearTheList.Name = "ButtonClearTheList";
            this.ButtonClearTheList.Size = new System.Drawing.Size(112, 23);
            this.ButtonClearTheList.TabIndex = 1;
            this.ButtonClearTheList.Text = "Clear the list";
            this.ButtonClearTheList.UseVisualStyleBackColor = true;
            this.ButtonClearTheList.Click += new System.EventHandler(this.ButtonClearTheList_Click);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(12, 70);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(112, 23);
            this.ButtonAddObject.TabIndex = 2;
            this.ButtonAddObject.Text = "Add object";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // ButtonDeleteObject
            // 
            this.ButtonDeleteObject.Location = new System.Drawing.Point(12, 99);
            this.ButtonDeleteObject.Name = "ButtonDeleteObject";
            this.ButtonDeleteObject.Size = new System.Drawing.Size(112, 23);
            this.ButtonDeleteObject.TabIndex = 3;
            this.ButtonDeleteObject.Text = "Delete object";
            this.ButtonDeleteObject.UseVisualStyleBackColor = true;
            this.ButtonDeleteObject.Click += new System.EventHandler(this.ButtonDeleteObject_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(130, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 108);
            this.listBox1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 141);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City и OrdersCount";
            this.columnHeader2.Width = 123;
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(12, 275);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(112, 23);
            this.ButtonNew.TabIndex = 6;
            this.ButtonNew.Text = "New button";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // FormLINQsql_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 423);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButtonDeleteObject);
            this.Controls.Add(this.ButtonAddObject);
            this.Controls.Add(this.ButtonClearTheList);
            this.Controls.Add(this.ButtonLoadingData);
            this.Name = "FormLINQsql_1";
            this.Text = "LINQsql_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoadingData;
        private System.Windows.Forms.Button ButtonClearTheList;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.Button ButtonDeleteObject;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button ButtonNew;
    }
}

