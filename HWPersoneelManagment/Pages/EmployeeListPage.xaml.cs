using HWPersoneelManagment.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HWPersoneelManagment.Pages
{
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            DataContext = Employee.Employees;
        }
        public Employee SelectedEmployee { get; set; }

        private void EmployeeEditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is Employee selectedEmployee)
            {
                NavigationService.Navigate(new EmployeeEditPage(selectedEmployee));
            }
        }
    }
}
