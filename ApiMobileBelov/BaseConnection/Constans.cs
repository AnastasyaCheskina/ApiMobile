using Microsoft.Data.SqlClient;

namespace ApiMobileBelov.BaseConnection
{
    public class Constans
    {
        public static string SqlConnection
        {
            get
            {
                var sc = new SqlConnectionStringBuilder
                {
                    DataSource = "ngknn.ru",
                    IntegratedSecurity = false,
                    InitialCatalog = "BelovMobileAppAPI",
                    UserID = "21P",
                    Password = "12357",
                    TrustServerCertificate = true
                };
                return sc.ToString();
            }
        }
    }
}
