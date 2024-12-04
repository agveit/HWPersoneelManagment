using HWPersoneelManagment.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HWPersoneelManagment.Pages
{
    public partial class EmployeeEditPage : Page
    {
        private Employee _employee;
        public EmployeeEditPage(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            DataContext = _employee;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            _employee.Name = NameTextBox.Text;
            _employee.Position = PositionTextBox.Text;
            NavigationService.GoBack();
        }
    }
}
