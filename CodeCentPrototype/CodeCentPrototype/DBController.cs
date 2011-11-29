using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows;




namespace CodeCentPrototype
{
    public class DBController
    {

        private static SqlConnection dbConn;
        //static SqlDataAdapter dbAdpt;
        // static DataTable dbt_studentInfo;
        //static DataTable dbt_studentStats;
        //static DataTable dbt_grades;
        //static DataSet dhcSet;

        /// <summary>
        /// Constructor for DBConn class
        /// </summary>
        public DBController()
        {
            // Create database connection
            dbConn = new System.Data.SqlClient.SqlConnection();

            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = codecent.Default.DBHost;
            // connection.Encrypt = true;
            connection.InitialCatalog = codecent.Default.DBInstance;
            connection.IntegratedSecurity = true; //CHANGE THIS IN NEXT ITERATION

            dbConn.ConnectionString = connection.ConnectionString;
        }


        /// <summary>
        /// Gets current db status 
        /// </summary>
        /// <returns>Bool indicating connection opened (true) or closed (false)</returns>
        public bool IsOpen()
        {
            if (dbConn.State == ConnectionState.Open)
                return true;
            return false;
        }


        public DataTable GetSchema(string table)
        {
            if (dbConn.State == ConnectionState.Open)
            {

                SqlCommand command = new SqlCommand("Select * FROM " + table, dbConn);
                command.Prepare();
                SqlDataReader x = command.ExecuteReader(CommandBehavior.SchemaOnly);                
                return x.GetSchemaTable();
            }
            return new DataTable();

        }
        /// <summary>
        /// Attempts to open the associated dbConn
        /// </summary>
        /// <returns>Bool indicating success or failure</returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public bool Open()
        {
            if (this.IsOpen())
                return true;

            try
            {
                dbConn.Open();
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Attempts to close the associated dbConn
        /// </summary>
        /// <returns>Bool indicating success or failure</returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public bool Close()
        {
            if (dbConn.State == ConnectionState.Closed)
                return true;

            try
            {
                dbConn.Close();
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Executes a query on the dbConn instance
        /// </summary>
        /// <param name="table">sql table to query</param>
        /// <param name="parameters">string array of parameters (columns)</param>
        /// <param name="condition">where condition</param>
        /// <returns>DataTable with results of query</returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public DataTable executeQuery(string table, string[] parameters, string condition)
        {
            try
            {
                //Perameterize this for next iteration!
                string sqlString = "SELECT ";
                if (parameters == null)
                    sqlString += "*";
                else
                    sqlString += string.Join(",", parameters);
                sqlString += " FROM " + table;
                if (condition != "" && condition != null)
                    sqlString += " WHERE " + condition;

                SqlCommand command = new SqlCommand(sqlString, dbConn);
                command.Prepare();

                DataTable resultsTable = new DataTable();
                SqlDataAdapter dbAdpt = new System.Data.SqlClient.SqlDataAdapter(command);
                dbAdpt.Fill(resultsTable);
                return resultsTable;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                throw;
            }

        }

        protected bool executeInsert(string[] parameters, string[] values, string table)
        {
            return false; //FIXME  
        }

        protected bool executeDelete(string condition, string table)
        {
            return false; //FIXME 
        }

        public int BackupDB(string outPath)
        {
            return 0; // FIXME
        }

        public int BackupDBForYear(int year, string outPath)
        {
            return 0; // FIXME
        }

        public int CancelBackup()
        {
            return 0; // FIXME
        }
    }
}
