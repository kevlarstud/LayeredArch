using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GuestPhoneBook.DataAccessLayer
{
    public class PhoneBookConfiguration
    {
        private static string providerName;

        public static string ProviderName
        {
            get { return PhoneBookConfiguration.providerName; }
            set { PhoneBookConfiguration.providerName = value; }
        }
        private static string connectionString;

        public static string ConnectionString
        {
            get { return PhoneBookConfiguration.connectionString; }
            set { PhoneBookConfiguration.connectionString = value; }
        }

        static PhoneBookConfiguration()
        {
            providerName = ConfigurationManager.ConnectionStrings["phoneBookConnection"].ProviderName;
            connectionString = ConfigurationManager.ConnectionStrings["phoneBookConnection"].ConnectionString;

        }
    }
}
