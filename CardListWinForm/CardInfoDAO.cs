using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardListWinForm
{
    
    public class CardInfoDAO
    {
        private static string loadConnectionString(string id = "Default") {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<CardInfo> LoadCards() {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString())) {
                var output = cnn.Query<CardInfo>("select * from Cards", new DynamicParameters());
                return output.ToList();
            }
        } 
    }
}
