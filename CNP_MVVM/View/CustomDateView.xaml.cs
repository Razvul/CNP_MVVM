﻿using CNP_MVVM.ViewModel;
using System;
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
using System.Windows.Shapes;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.View
{
    /// <summary>
    /// Interaction logic for CustomDateView.xaml
    /// </summary>
    public partial class CustomDateView : Window
    {
        public CustomDateView()
        {
            InitializeComponent();
        }

        private void Combobox_Luni_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = sender as ComboBox;
            var b = a.SelectedIndex;// cum fac sa incarce din nou combobox zile?
            var c = Utilities.Utility.GetMaxDays(b);//cum il trimit?
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var item = Utility.GetCC
                (Utility.GetSex(Combobox_Gender.Text, Combobox_An.Text),
                Utility.GetYear(Combobox_An.Text),
                Utility.GetMonth(Combobox_Luni.Text),
                Utility.GetZi(Combobox_Zile.Text),
                Utility.GetJudet(Combobox_Judete.Text),
                Utility.GetNNN());

            TextBox_CNP.Text = Utility.GetCNP
                (Utility.GetSex(Combobox_Gender.Text, Combobox_An.Text),
                Utility.GetYear(Combobox_An.Text),
                Utility.GetMonth(Combobox_Luni.Text),
                Utility.GetZi(Combobox_Zile.Text),
                Utility.GetJudet(Combobox_Judete.Text),
                Utility.GetNNN(),
                item);
        }
    }
}