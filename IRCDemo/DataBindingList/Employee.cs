using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingList
{
    class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(
            [CallerMemberName] string caller="")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        public static ObservableCollection<Employee> GetEmployess()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name="Washington",Title="President 1"});
            employees.Add(new Employee() { Name = "Adams", Title = "President 2" });
            employees.Add(new Employee() { Name = "Jefferson", Title = "President 3" });
            employees.Add(new Employee() { Name = "Madison", Title = "President 4" });
            employees.Add(new Employee() { Name = "Monroe", Title = "President 5" });
            return employees;
        }
    }
}
