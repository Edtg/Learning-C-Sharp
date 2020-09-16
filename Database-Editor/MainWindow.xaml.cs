using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Database_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MyViewModel();
        }
    }

    public class MyViewModel
    {
        public class Person
        {
            public int ID { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public int Age { get; set; }

            public Person(int id, String firstname, String lastname, int age)
            {
                ID = id;
                FirstName = firstname;
                LastName = lastname;
                Age = age;
            }
        }

        public List<Person> Items
        {
            get { return new List<Person> {
                new Person(1, "Person", "One", 20)
            }; }
        }
    }
}
