using System.Data.SqlClient; 

namespace BeautyStoreApp.Data
{

    public class DatabaseConnection
    {
       
        private string connectionString = "Server=Waseequr\\SQLEXPRESS;Database=BeautyStoreDB;Integrated Security=true;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}