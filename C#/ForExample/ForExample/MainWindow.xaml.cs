using ForExample.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace ForExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private List<Student> students;

        public List<Student> Students { get => students; set { students = value; OnPropertyChanged(); } }
        public MainWindow()
        {
            InitializeComponent();
            Students = new() 
            {
                new Student { Name = "Ali", Surname = "Mustafayev", DateOfBirth = new DateOnly(2009, 06, 20) },
                new Student { Name = "Tahir", Surname = "Aliyev", DateOfBirth = new DateOnly(2001, 08, 01) },
                new Student { Name = "Seltenet", Surname = "Suleymanli", DateOfBirth = new DateOnly(2004, 01, 31) },
                new Student { Name = "Abdulla", Surname = "Babayev", DateOfBirth = new DateOnly(2005, 02, 07) },
                new Student { Name = "Arzum", Surname = "Hasanzade", DateOfBirth = new DateOnly(2009, 10, 01) },
                new Student { Name = "Asgar", Surname = "Abbasli", DateOfBirth = new DateOnly(2008, 06, 22) },
                new Student { Name = "Ismayil", Surname = "Bagirov", DateOfBirth = new DateOnly(2008, 03, 15) },
            };

            DataContext = this;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Students = Students.Where(st => st.DateOfBirth.Year <= 2006).ToList();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}