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
		public MainWindow()
		{
			this.InitializeComponent();
			// Insert code required on object creation below this point.
			FakeStudent [] myList = new FakeStudent[4];
			myList[0] = new FakeStudent("Joe Santos", "4", "3");
			myList[1] = new FakeStudent("Sam Conklin", "3", "2");
			myList[2] = new FakeStudent("Carol Fredricks", "2", "1");
			myList[3] = new FakeStudent("Sara Hern", "4", "4");
			listStudents.Items.Add(myList[0].name);
			listStudents.Items.Add(myList[1].name);
			listStudents.Items.Add(myList[2].name);
			listStudents.Items.Add(myList[3].name);
		}

		private void listStudents_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
		}
	}
	
	public class FakeStudent{
		public string name;
		public string GPA;
		public string birthday;
		
		public FakeStudent(string name, string GPA, string birthday){
			this.name = name;
			this.GPA = GPA;
			this.birthday = birthday;
		}
		
	}
}