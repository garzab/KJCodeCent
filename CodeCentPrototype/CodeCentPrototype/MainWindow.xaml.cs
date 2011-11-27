using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input; 
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CodeCentPrototype
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        StudentPresenter stPresenter;

		public MainWindow()
		{
			this.InitializeComponent();
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // Populate year list with current year, previous 'x' years
                 
            
            stPresenter = new StudentPresenter(this);

            //Load current year student list
            string now = DateTime.Now.Year.ToString();
            for(int i=0; i < this.comboYear.Items.Count; i++){
                ComboBoxItem x = (ComboBoxItem)this.comboYear.Items.GetItemAt(i);
                if (x.Content.ToString() == now)
                    this.comboYear.SelectedIndex = i;
            }
        }

        private void comboYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(stPresenter != null)
                stPresenter.SelectedYearChanged(sender, e);
        }

        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(stPresenter != null)
                stPresenter.selectedStudentChanged(sender, e);
        }


        

	}

}