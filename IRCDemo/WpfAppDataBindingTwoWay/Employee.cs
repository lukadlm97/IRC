using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataBindingTwoWay
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChangedEventHandler();
            }
        }
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChangedEventHandler();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChangedEventHandler([CallerMemberName]string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        public static Employee GetEmployee()
        {
            var emp = new Employee() { Name = "Tom", Title = "Developer" };
            return emp;
        }

    }
}
