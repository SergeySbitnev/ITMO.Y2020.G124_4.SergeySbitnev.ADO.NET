using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBCommand
{
    public partial class formDBCommand : Form
    {
        public formDBCommand()
        {
            InitializeComponent();
        }

        private void ButtonDataRequest_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand1.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result.Append(reader[i].ToString() + "\t");
                        }
                        result.Append(Environment.NewLine);

                    }
                    TextBoxResult.Text = result.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonBatchRequest_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            using (sqlConnection1)
            {
                sqlCommand1.CommandText = "SELECT CustomerID, CompanyName FROM Customers;" + "SELECT ProductName, UnitPrice, QuantityPerUnit FROM Products;";
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    bool MoreResults = false;
                    do
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                result.Append(reader[i].ToString() + "\t");
                            }
                            result.Append(Environment.NewLine);
                            

                        }
                        
                        MoreResults = reader.NextResult();
                    } while (MoreResults);
                    TextBoxResult.Text = result.ToString();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonProcedureCall_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand2.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i <reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    TextBoxResult.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCreateTable_Click(object sender, EventArgs e)
        {
            using (sqlConnection1)
            {
                sqlCommand3.CommandText = "CREATE TABLE SalesPersons " +
                    "(" +
                    "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                    "[FirstName] [nvarchar] (50) NULL, " +
                    "[LastName] [nvarchar] (50) NULL" +
                    ")";

                try
                {
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    MessageBox.Show("SalesPersons table created");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonParameterQuery_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder(); try
            {
                sqlCommand4.Parameters["@City"].Value = TextBoxCity.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand4.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++) 
                    { 
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                TextBoxResult.Text = results.ToString();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void ButtonParameterProcedure_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder(); try
            {
                sqlCommand5.Parameters["@CategoryName"].Value = TextBoxCategoryName.Text;
                sqlCommand5.Parameters["@OrdYear"].Value = TextBoxOrdYear.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand5.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                TextBoxResult.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
