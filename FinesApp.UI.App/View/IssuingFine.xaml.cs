using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
using FinesApp.Domain.Entities;

namespace FinesApp.UI.App.View
{
    /// <summary>
    /// Логика взаимодействия для IssuingFine.xaml
    /// </summary>
    public partial class IssuingFine : Window
    {
        public IssuingFine()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            if(CorrectInputData())
                this.DialogResult = true;
        }

        public Fine AcceptFine
        {         
            get
            {
                var hour = ((DateTime)TimePickerDateOfViolation.SelectedTime).Hour;
                var minute = ((DateTime)TimePickerDateOfViolation.SelectedTime).Minute;
                var day = ((DateTime)DatePickerDateOfViolation.SelectedDate).Day;
                var month = ((DateTime)DatePickerDateOfViolation.SelectedDate).Month;
                var year = ((DateTime)DatePickerDateOfViolation.SelectedDate).Year;
                return new Fine(
                    DateOnly.FromDateTime(DateTime.Today),
                    new DateTime(year, month, day, hour, minute, 0),
                    new TypeOfMiolation(TextBoxArticle.Text, TextBoxPart.Text, TextBoxMiolDescription.Text),
                    TextBoxIssuedBy.Text,
                    TextBoxDiscription.Text,
                    Convert.ToDecimal(TextBoxMonetary.Text),
                    DateOnly.FromDateTime(DateTime.Today).AddMonths(1));
            }
        }

        private void DecimalTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            decimal result;
            if (!decimal.TryParse(TextBoxMonetary.Text + e.Text, out result))
            {
                e.Handled = true;
            }
        }

        private bool CorrectInputData()
        {
            if(TextBoxArticle.Text == "")
            {
                MessageBox.Show("The type of violation is not selected");
                return false;
            }
            if(TextBoxIssuedBy.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("The 'Issued by' field is empty");
                return false;
            }
            if(TextBoxDiscription.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("The 'Discription' field is empty");
                return false;
            }
            if(TextBoxMonetary.Text == "")
            {
                MessageBox.Show("The 'Amount' field is empty");
                return false;
            }
            if(TimePickerDateOfViolation.SelectedTime == null)
            {
                MessageBox.Show("The time of the violation is not selected");
                return false;
            }
            if (DatePickerDateOfViolation.SelectedDate == null)
            {
                MessageBox.Show("The date of the violation is not selected");
                return false;
            }
            return true;
        }

        private void Choose_Miolation(object sender, RoutedEventArgs e)
        {
            ChoosingMiolation choosingMiolationWindow = new();
            if (choosingMiolationWindow.ShowDialog() == true)
            {
                if (choosingMiolationWindow.SelectedMiolation != null)
                {
                    TextBoxArticle.Text = choosingMiolationWindow.SelectedMiolation.Article;
                    TextBoxPart.Text = choosingMiolationWindow.SelectedMiolation.Part;
                    TextBoxMiolDescription.Text = choosingMiolationWindow.SelectedMiolation.Description;
                }
                    
            }
        }
    }
}
