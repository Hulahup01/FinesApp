using FinesApp.Domain.Entities;
using FinesApp.UI.App.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для DriversSearch.xaml
    /// </summary>
    public partial class DriversSearch : UserControl
    {
        public DriversSearch()
        {
            InitializeComponent();
        }
        private string _filterText;
        public string FilterText
        {
            get { return _filterText; }
            set
            {
                _filterText = value;
                OnPropertyChanged(nameof(FilterText));
                CollectionViewSource.GetDefaultView(DriverData.ItemsSource).Refresh();
            }
        }

        private void MyDataFilter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            if (e.Item is Driver myData && myData.License.SerialNumber.Contains(FilterText))
            {
                e.Accepted = true;
                return;
            }

            e.Accepted = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnSearch(object sender, RoutedEventArgs e)
        {
            FilterText = textBoxSearch.Text;
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterText = textBoxSearch.Text;
        }

        private void Row_Click(object sender, SelectionChangedEventArgs e)
        {
            var selectedDriver = (sender as DataGrid)?.SelectedItem as Driver;
            if(selectedDriver != null)
                NavigationVM.idDriver = selectedDriver.Id;
            //if (sender is DataGridRow row && row.Item is Driver item)
            //{
            //    NavigationVM.idDriver = item.Id;
            //}
        }

        public async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Run( () =>
            {
                DriverSearchVM.ExecuteRefreshCommand("load");
            });
        }
    }
}
