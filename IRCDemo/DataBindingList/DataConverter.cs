using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataBindingList
{
    public class DataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("d");
        }

        public object ConvertBack(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            string strValues = value as string;
            DateTime resultDateTame;
            if(DateTime.TryParse(strValues,out resultDateTame))
            {
                return resultDateTame;
            }
            throw new Exception("Unable to convert string to date time");
        }
    }
}
