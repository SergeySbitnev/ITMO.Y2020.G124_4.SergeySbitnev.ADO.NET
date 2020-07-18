namespace DBCommand
{
    partial class formDBCommand
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ButtonDataRequest = new System.Windows.Forms.Button();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.ButtonBatchRequest = new System.Windows.Forms.Button();
            this.ButtonProcedureCall = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.ButtonCreateTable = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.ButtonParameterQuery = new System.Windows.Forms.Button();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.ButtonParameterProcedure = new System.Windows.Forms.Button();
            this.TextBoxCategoryName = new System.Windows.Forms.TextBox();
            this.TextBoxOrdYear = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\ITMO.Y2020.G124_4.SergeySb" +
    "itnev.ADO.NET\\northwind.mdf;Initial Catalog=northwind;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // ButtonDataRequest
            // 
            this.ButtonDataRequest.Location = new System.Drawing.Point(12, 12);
            this.ButtonDataRequest.Name = "ButtonDataRequest";
            this.ButtonDataRequest.Size = new System.Drawing.Size(106, 23);
            this.ButtonDataRequest.TabIndex = 0;
            this.ButtonDataRequest.Text = "Data request";
            this.ButtonDataRequest.UseVisualStyleBackColor = true;
            this.ButtonDataRequest.Click += new System.EventHandler(this.ButtonDataRequest_Click);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(124, 14);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxResult.Size = new System.Drawing.Size(250, 300);
            this.TextBoxResult.TabIndex = 1;
            // 
            // ButtonBatchRequest
            // 
            this.ButtonBatchRequest.Location = new System.Drawing.Point(12, 41);
            this.ButtonBatchRequest.Name = "ButtonBatchRequest";
            this.ButtonBatchRequest.Size = new System.Drawing.Size(106, 23);
            this.ButtonBatchRequest.TabIndex = 2;
            this.ButtonBatchRequest.Text = "Batch request";
            this.ButtonBatchRequest.UseVisualStyleBackColor = true;
            this.ButtonBatchRequest.Click += new System.EventHandler(this.ButtonBatchRequest_Click);
            // 
            // ButtonProcedureCall
            // 
            this.ButtonProcedureCall.Location = new System.Drawing.Point(12, 70);
            this.ButtonProcedureCall.Name = "ButtonProcedureCall";
            this.ButtonProcedureCall.Size = new System.Drawing.Size(106, 23);
            this.ButtonProcedureCall.TabIndex = 3;
            this.ButtonProcedureCall.Text = "Procedure call";
            this.ButtonProcedureCall.UseVisualStyleBackColor = true;
            this.ButtonProcedureCall.Click += new System.EventHandler(this.ButtonProcedureCall_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // ButtonCreateTable
            // 
            this.ButtonCreateTable.Location = new System.Drawing.Point(12, 99);
            this.ButtonCreateTable.Name = "ButtonCreateTable";
            this.ButtonCreateTable.Size = new System.Drawing.Size(106, 23);
            this.ButtonCreateTable.TabIndex = 4;
            this.ButtonCreateTable.Text = "Create table";
            this.ButtonCreateTable.UseVisualStyleBackColor = true;
            this.ButtonCreateTable.Click += new System.EventHandler(this.ButtonCreateTable_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // ButtonParameterQuery
            // 
            this.ButtonParameterQuery.Location = new System.Drawing.Point(12, 328);
            this.ButtonParameterQuery.Name = "ButtonParameterQuery";
            this.ButtonParameterQuery.Size = new System.Drawing.Size(116, 23);
            this.ButtonParameterQuery.TabIndex = 5;
            this.ButtonParameterQuery.Text = "Parameter query";
            this.ButtonParameterQuery.UseVisualStyleBackColor = true;
            this.ButtonParameterQuery.Click += new System.EventHandler(this.ButtonParameterQuery_Click);
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(134, 330);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(240, 20);
            this.TextBoxCity.TabIndex = 6;
            this.TextBoxCity.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers\r\nWHERE        (C" +
    "ity = @City)";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // ButtonParameterProcedure
            // 
            this.ButtonParameterProcedure.Location = new System.Drawing.Point(12, 357);
            this.ButtonParameterProcedure.Name = "ButtonParameterProcedure";
            this.ButtonParameterProcedure.Size = new System.Drawing.Size(116, 23);
            this.ButtonParameterProcedure.TabIndex = 7;
            this.ButtonParameterProcedure.Text = "Parameter procedure";
            this.ButtonParameterProcedure.UseVisualStyleBackColor = true;
            this.ButtonParameterProcedure.Click += new System.EventHandler(this.ButtonParameterProcedure_Click);
            // 
            // TextBoxCategoryName
            // 
            this.TextBoxCategoryName.Location = new System.Drawing.Point(134, 359);
            this.TextBoxCategoryName.Name = "TextBoxCategoryName";
            this.TextBoxCategoryName.Size = new System.Drawing.Size(240, 20);
            this.TextBoxCategoryName.TabIndex = 8;
            this.TextBoxCategoryName.Text = "Beverages";
            // 
            // TextBoxOrdYear
            // 
            this.TextBoxOrdYear.Location = new System.Drawing.Point(134, 385);
            this.TextBoxOrdYear.Name = "TextBoxOrdYear";
            this.TextBoxOrdYear.Size = new System.Drawing.Size(240, 20);
            this.TextBoxOrdYear.TabIndex = 9;
            this.TextBoxOrdYear.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4, "OrderDate")});
            // 
            // formDBCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 454);
            this.Controls.Add(this.TextBoxOrdYear);
            this.Controls.Add(this.TextBoxCategoryName);
            this.Controls.Add(this.ButtonParameterProcedure);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.ButtonParameterQuery);
            this.Controls.Add(this.ButtonCreateTable);
            this.Controls.Add(this.ButtonProcedureCall);
            this.Controls.Add(this.ButtonBatchRequest);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.ButtonDataRequest);
            this.Name = "formDBCommand";
            this.Text = "DBCommand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button ButtonDataRequest;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Button ButtonBatchRequest;
        private System.Windows.Forms.Button ButtonProcedureCall;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button ButtonCreateTable;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button ButtonParameterQuery;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button ButtonParameterProcedure;
        private System.Windows.Forms.TextBox TextBoxCategoryName;
        private System.Windows.Forms.TextBox TextBoxOrdYear;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

