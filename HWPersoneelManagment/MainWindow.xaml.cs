using HWPersoneelManagment.Pages;
using System;
using System.Windows;

namespace HWPersoneelManagment
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Source = new Uri("Pages/HomePage.xaml", UriKind.Relative);
        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new HomePage());
        }

        private void EmployeeListButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new EmployeeListPage());
        }
    }
}
