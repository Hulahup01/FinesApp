﻿using FinesApp.UI.App.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinesApp.UI.App.View
{
    /// <summary>
    /// Логика взаимодействия для Miolations.xaml
    /// </summary>
    public partial class Miolations : UserControl
    {
        public Miolations()
        {
            InitializeComponent();
        }

        public async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                await MiolationsVM.ConfigureAndInitRepositoryAsync();
            });
        }

    }
}
