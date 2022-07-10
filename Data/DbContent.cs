using Dapper;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using PhoneAnalyze.Models;

namespace PhoneAnalyze.Data
{
    public class DbContent
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;port=8889;database=phoneanalize;user=root;password=root;");

        public DbContent()
        {
            sqlConnect.Open();
        }

        public List<PhoneViewModel> GetSelectPhones()
        {
            var allPhones = new List<PhoneViewModel>();
            using (IDbConnection db = sqlConnect)
            {
                allPhones = db.Query<PhoneViewModel>("select `PhoneId`, `Name` from phones").AsList();
                System.Console.WriteLine(allPhones.Count);
            }            
            return allPhones;
        }
        public List<PhoneViewModel> GetAllPhones()
        {
            var allPhones = new List<PhoneViewModel>();           
            using(IDbConnection db = sqlConnect)
            {
                allPhones = db.Query<PhoneViewModel>("select * from phones").AsList();
            }
            return allPhones;
        }
    }
}