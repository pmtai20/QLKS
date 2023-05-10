using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLKS
{
    public static class DataAccess
    {
        private static string connectionString = "Server=localhost;Database=QLKS;Trusted_Connection=True;";


        public static void LoadData()
        {

            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null && !mainForm.IsDisposed && mainForm.IsHandleCreated)
            {
                mainForm.LoadData();
            }
            else
            {
                mainForm = new MainForm();
                mainForm.LoadData();
                mainForm.Show();
            }

        }

        // use to execute select
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }

                connection.Close();
            }

            return dataTable;
        }

        internal static DataTable GetData(string v)
        {
            throw new NotImplementedException();
        }

        // use to execute insert, update, delete
        public static int ExecuteNonQuery(string query)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new(query, connection))
                {
                    result = command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return result;
        }
    }
}