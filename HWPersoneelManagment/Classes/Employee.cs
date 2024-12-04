using System.Collections.ObjectModel;

namespace HWPersoneelManagment.Classes
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public static ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>()
        {
            new Employee {Name = "Квазаров О.П", Position = "Директор"},
            new Employee {Name = "Ульянов Т.С.", Position = "Менеджер"},
            new Employee {Name = "Каримов А. В.", Position = "Менеджер"}
        };


    }
}
