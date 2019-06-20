using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataConvertDemo
{
    class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged(); }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value;OnPropertyChanged(); }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value;OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public Employee(string name,string title,DateTime startDate)
        {
            Name = name;
            Title = title;
            StartDate = startDate;
        }
    }
}
