using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Data;



namespace CodeCentPrototype
{

    // This class acts as presenter for student information - receives events from UI, populates correct UI fields what a selected student 
    public class StudentPresenter
    {
        private MainWindow windowRef;
        private DBController dbConn;

        public StudentPresenter(MainWindow reference)
        {
            windowRef = reference;
            dbConn = new DBController();
        }

        public void SelectedYearChanged(object sender, SelectionChangedEventArgs e)
        {                     
            int year;
            try
            {
                ComboBoxItem cb = (ComboBoxItem)windowRef.comboYear.SelectedItem;
                year = Int32.Parse(cb.Content.ToString());
            }
            catch(Exception)
            {
                throw;
            }
            
            if (dbConn.Open())
            {
                DataTable studentInfo = dbConn.executeQuery("StudentInfo", null, null);

                dbConn.Close();

                /*
                 * This is only temporary! Need basic UI functionality for midterm presentation
                 */
                List<string> students = new List<string>();
                string title = "";
                for (int i = 0; i < studentInfo.Rows.Count; i++)
                {
                    title = studentInfo.Rows[i].ItemArray.ElementAt(4).ToString();
                    title += ", ";
                    title += studentInfo.Rows[i].ItemArray.ElementAt(2).ToString();
                    students.Add(title);
                }
                students.Sort();
                windowRef.listStudents.ItemsSource = students;                
            }

        }

        // TO DO: Add presentation logic
    }
}
