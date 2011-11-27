using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

using System.Windows;

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

        public  void SelectedYearChanged(object sender, SelectionChangedEventArgs e)
        {
                     
            int year = 0;
            try
            {
                ComboBoxItem cb = (ComboBoxItem)windowRef.comboYear.SelectedItem;
                year = Int32.Parse(cb.Content.ToString());
                MessageBox.Show("Year Changed to " + year.ToString());
            }
            catch(ArgumentNullException)
            {
            }
            catch(FormatException)
            {
            }
            catch(OverflowException)
            {
            }

            if (dbConn.IsOpen())
            {

            }

        }

        // TO DO: Add presentation logic
    }
}
