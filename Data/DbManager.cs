using System;
namespace PhoneAnalyze.Data
{
    public class DbManager
    {
        private static DbContent db;

        public static DbContent DB {
            get
            {
                if (db == null) db = new DbContent();
                return db;
            }
        }
    }
}
