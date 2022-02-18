using System;
using System.Data.SQLite;

namespace SQLiteCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCountries();
        }
        private static void ReadCountries()
        {
            Database databaseObj = new Database();
            string query = "SELECT Country.countryname, Capital.capitalname from Capital join country on Capital.countryid = Country.rowid";
            SQLiteCommand myCommend = new SQLiteCommand(query, databaseObj.myConnection);
            databaseObj.OpenConnection();
            SQLiteDataReader data = myCommend.ExecuteReader();

            if(data.HasRows)
            {
                while(data.Read())
                {
                    Console.WriteLine($"Country: {data["Country"]}. Capital: {data["Capital"]}");
                }
            }
            databaseObj.CloseConnection();
        }
    
    
    
    
    }
}
