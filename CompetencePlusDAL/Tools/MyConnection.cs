using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using ADOX; //Requires Microsoft ADO Ext. 2.8 for DDL and Security

 

namespace CompetencePlus.Tools
{
    /// <summary>
    /// Il permet de se connecter avec la base de données et d'exécuter les requêtes SQL
    /// </summary>
    public class MyConnection
    {   
        public static OleDbConnection Connection;
        public static OleDbCommand Command;
        public static String DataBaseName = "db_cplus";

        ///  En mode développement la base de données doit être installé dans le chemin suivant "C:\db_cplus\db_cplus.accdb"
        ///  En mode déploiement la base de données doit être installer dans le répertoire projet
        /// string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CompétencePlus.accdb;Persist Security Info=True";
        static string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= db_cplus.accdb;Persist Security Info=True";

        
        
        /// <summary>
        /// Exécuter les requêtes SQL : Update, Delete, Insert
        /// </summary>
        /// <param name="Requete">La requête SQL à exécuter</param>
        public static int ExecuteNonQuery(string Requete)
        {

            Connection = new OleDbConnection(ConnectionString);
            Command = Connection.CreateCommand();
            Command.CommandText = Requete;
            Connection.Open();
            int result =  Command.ExecuteNonQuery();
            Connection.Close();
            return result;
        }
        /// <summary>
        /// Exécute la requête SQL : Select
        /// </summary>
        /// <param name="Requete"></param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string Requete)
        {
            Connection = new OleDbConnection(ConnectionString);
            Command = Connection.CreateCommand();
            Command.CommandText = Requete;
            Connection.Open();
            OleDbDataReader read = Command.ExecuteReader();
            return read;
        }
        /// <summary>
        /// Fermiture de la connexion aprés l'appelle de la méthode "ExecuteNonQuery"
        /// </summary>
        public static void Close (){
            Connection.Close();
        }

        

   

        


    }
}
