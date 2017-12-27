using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AdmissonDAL
{
    public class AdmissConfiguration
    {
        public static string providerName;
        public static string ProviderName
        {
            get { return AdmissConfiguration.providerName; }
            set { AdmissConfiguration.providerName = value; }
        }
        public static string connectionString;
        public static string ConnectionString
        {
            get { return AdmissConfiguration.connectionString; }
            set { AdmissConfiguration.connectionString = value; }
        }
        static AdmissConfiguration()
        {
            providerName = ConfigurationManager.ConnectionStrings["AdmissionConnection"].ProviderName;
            connectionString = ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString;
        }
    }
}
