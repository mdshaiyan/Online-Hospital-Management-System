using Microsoft.Data.SqlClient;

namespace Hospital_Management
{
    public static class Database
    {
        private static string connectionString =
            @"Server=localhost;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}