using FinesApp.Domain.Entities;
using FinesApp.UI.App.Utilities;
using FinesApp.Domain.Constants;
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
using FInesApp.Constants;

namespace FinesApp.UI.App.View
{
    /// <summary>
    /// Логика взаимодействия для ChoosingMiolation.xaml
    /// </summary>
    public partial class ChoosingMiolation : Window
    {
        public TypeOfMiolation SelectedMiolation { get; set; }
        public ObservableRangeCollection<TypeOfMiolation> MiolationsList { get; set; } = new();

        public ChoosingMiolation()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void LoadMiolations(object sender, EventArgs e)
        {
            MiolationsList.AddRange(LLL.MiolationsList);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedMiolation = (sender as DataGrid)?.SelectedItem as TypeOfMiolation;
            this.DialogResult = true;
        }
    }
}
