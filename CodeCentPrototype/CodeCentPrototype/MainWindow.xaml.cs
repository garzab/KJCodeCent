using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;

namespace CodeCentPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        StudentPresenter stPresenter;

        public MainWindow()
        {
            InitializeComponent();

            // Insert code required on object creation below this point.
        }

        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Populate year list with current year, previous 'x' years


            stPresenter = new StudentPresenter(this);

            //Load current year student list
            string now = DateTime.Now.Year.ToString();
            for (int i = 0; i < this.comboYear.Items.Count; i++)
            {
                ComboBoxItem x = (ComboBoxItem)this.comboYear.Items.GetItemAt(i);
                if (x.Content.ToString() == now)
                    this.comboYear.SelectedIndex = i;
            }
        }

        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (stPresenter != null)
                stPresenter.selectedStudentChanged(sender, e);

        }

        private void comboYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (stPresenter != null)
                stPresenter.SelectedYearChanged(sender, e);

        }


    }
}
