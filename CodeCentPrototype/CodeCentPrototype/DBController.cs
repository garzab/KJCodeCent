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
            //connection.InitialCatalog = codecent.Default.DBInstance;
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

        /// <summary>
        /// Attempts to open the associated dbConn
        /// </summary>
        /// <returns>Bool indicating success or failure</returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        public bool Open() 
        {
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
        /// <param name="table"></param>
        /// <param name="parameters"></param>
        /// <param name="condition"></param>
        /// <returns>DataTable with results of query</returns>
        /// <exception cref="System.Data.SqlClient.SqlException"></exception>
        protected DataTable executeQuery(string table, string[] parameters, string condition)
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
                if (condition != "")
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


        //Junk//////////////////////////////////////////////////
        /*
        public void getStudents()
        {
            // Create database connection
            dbConn = new System.Data.SqlClient.SqlConnection();
            dbConn.ConnectionString = "Data Source=ONLYIMAGINARY\\SQLEXPRESSDHC;Initial Catalog=DHCDB;Integrated Security=True";

            // open database
            dbConn.Open();
            MessageBox.Show("DB Open");

            // Creates the 3 tables and fills them with their appropriate info
            DataTable dbt_studentInfo = dbt_getTable("StudentInfo", dbConn);
            DataTable dbt_studentStats = dbt_getTable("StudentStats", dbConn);
            DataTable dbt_grades = dbt_getTable("Grades", dbConn);

            // Create a new dataset to hold all of the tables
            DataSet dhcSet = new DataSet(); // This is the the dataset that should be passed around for general viewing
            dhcSet.Tables.Add(dbt_studentInfo);
            dhcSet.Tables.Add(dbt_studentStats);
            dhcSet.Tables.Add(dbt_grades);


            // Data rows, you collect from the db with these
            DataRow infoRow = dhcSet.Tables["StudentInfo"].Rows[0];
            DataRow gradeRow = dhcSet.Tables["Grades"].Rows[0];

            string test = "";
            foreach (DataRow row in dhcSet.Tables["StudentInfo"].Rows)
            {
                test += row.ItemArray.GetValue(0).ToString() + ", ";
                test += row.ItemArray.GetValue(1).ToString() + ", ";
                MessageBox.Show(test);
            }

            // ====== GARBAGE DEMONSTRATING PULL ======
            String testStudentInfo = "";
            testStudentInfo += infoRow.ItemArray.GetValue(0).ToString() + ", ";
            testStudentInfo += infoRow.ItemArray.GetValue(1).ToString() + ", ";
            testStudentInfo += infoRow.ItemArray.GetValue(2).ToString() + ", ";
            testStudentInfo += infoRow.ItemArray.GetValue(3).ToString() + ", ";
            testStudentInfo += infoRow.ItemArray.GetValue(10).ToString() + ", ";
            testStudentInfo += infoRow.ItemArray.GetValue(11).ToString() + ", ";
            testStudentInfo += infoRow.ItemArray.GetValue(12).ToString() + "!";
            MessageBox.Show(testStudentInfo);
            // =======================================


            // ====== GARBAGE DEMONSTRATING PULL =====
            String testStudentGrades = "";
            testStudentGrades += gradeRow.ItemArray.GetValue(0).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(1).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(2).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(3).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(10).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(11).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(12).ToString() + "!";
            testStudentGrades += gradeRow.ItemArray.GetValue(20).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(21).ToString() + ", ";
            testStudentGrades += gradeRow.ItemArray.GetValue(22).ToString() + "!";
            MessageBox.Show(testStudentGrades);
            // =======================================
        }
        */
    }
}
