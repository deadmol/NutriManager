using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class DAL
    {
        /// <summary>
        /// Fonction exécutant une requête SQL.
        /// </summary>
        /// <param name="qry">Requête SQL</param>
        /// <returns>Jeu de résultats du select</returns>
        public static List<Dictionary<string, string>> SelectQuery(string qry)
        {
            List<Dictionary<string, string>> Result = new List<Dictionary<string, string>>();

            using (IDbConnection connection = new SqlConnection(@"Data Source=DEADMOL-PC\SQLEXPRESS;Initial Catalog=Db_NutriManager;Integrated Security=True"))
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = qry;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Result.Add(new Dictionary<string, string>());
                            for (int i = 0 ; i < reader.FieldCount ; i++)
                            {
                                Result.ElementAt(Result.Count-1).Add(reader.GetName(i), reader.GetValue(i).ToString());
                            }
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }  

            return Result;
        }

        /// <summary>
        /// Exécute query SQL sans retour (Insert, Update, Delete)
        /// </summary>
        /// <param name="qry">Requête</param>
        public static void ExecuteQuery(string qry)
        {
            using (IDbConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"" + @"C:\Users\ASUS\Desktop\NutriManager\NutriManager\NutriManager.mdf" + "\";Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = qry;
                    command.ExecuteNonQuery();
                }
                connection.Close();
            } 
        }

        /// <summary>
        /// Je sais pas pourquoi, mais si ya pas Main() ça plante
        /// </summary>
        public static void Main()
        {

        }
    }
}
