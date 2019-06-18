﻿using System;
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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full name: ");
            sb.Append(UserName.Text);
            sb.Append(" Sex? ");
            sb.Append((bool) Male.IsChecked ? " Male ":" Female ");
            sb.Append(" Devices: ");
            sb.Append((bool) Desktop.IsChecked ? " Desktop ":" ");
            sb.Append((bool) Laptop.IsChecked? " Laptop ":" ");
            sb.Append((bool) Tablet.IsChecked?" Tablet ":" ");
            sb.Append(" Job: ");
            sb.Append(Job.SelectedItem.ToString());
            sb.Append(" Delivery date:");
            sb.Append(DeliveryDate.ToString());
            MessageBox.Show(sb.ToString());
        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newlySelectedItem = e.AddedItems[0];
            MessageBox.Show(newlySelectedItem.ToString());
        }
    }
}
