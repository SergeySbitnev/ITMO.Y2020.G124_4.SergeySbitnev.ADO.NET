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
using System.Runtime.CompilerServices;

namespace DBConnection
{
    public partial class DBConnection : Form
    {
        SqlConnection connection = new SqlConnection();
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = true";

        public DBConnection()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }


        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            connectDB.Enabled = (e.CurrentState == ConnectionState.Closed);
            asyncConnectionDB.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectDB.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void openDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Database connection " + connection.Database + " completed successfully " + "\nServer: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Database connection already established");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch (SqlException XcpSQL)
            //{
            //    foreach (SqlError se in XcpSQL.Errors)
            //    {
            //        MessageBox.Show(se.Message, "Source of error: " + se.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка соединения с базой данных");
            //}

        }

        private void closeDB_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Database connection closed");
            }
            else
                MessageBox.Show("Database connection is already closed");
        }

        private async void asyncConnectionDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Database connection " + connection.Database + " completed successfully " + "\nServer: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Database connection already established");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch (SqlException XcpSQL)
            //{
            //    foreach (SqlError se in XcpSQL.Errors)
            //    {
            //        MessageBox.Show(se.Message, "Source of error: " + se.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка соединения с базой данных");
            //}
        }
    }
}
