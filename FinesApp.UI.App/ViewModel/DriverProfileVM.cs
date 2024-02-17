using FinesApp.Infrastructure.Data.Repositories;
using FinesApp.UI.App.Utilities;
using FinesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FinesApp.UI.App.View;
using System.Collections.Specialized;

namespace FinesApp.UI.App.ViewModel
{
    public class DriverProfileVM:ViewModelBase
    {
        private static Driver _currentDriver;
        public static DriverRepository DriverRepository { get; set; } = new()!;
        public static ObservableRangeCollection<Fine> FineList { get; set; } = new()!;
        public ICommand IssuingFineCommand { get; set; }
        public Driver CurrentDriver
        {
            get { return _currentDriver; }
            set
            {
                _currentDriver = value;
                OnPropertyChanged(nameof(CurrentDriver));
            }
        }
        public DriverProfileVM()
        {
            IssuingFineCommand = new RelayCommand(IssuingFine);
        }

        public void IssuingFine(object obj)
        {
            if (CurrentDriver == null)
                return;

            IssuingFine IssuingFineWindow = new();

            if (IssuingFineWindow.ShowDialog() == true)
            {
                var fine = IssuingFineWindow.AcceptFine;
                CurrentDriver.Fines.Add(fine);
                DriverRepository.Update(CurrentDriver);
                DriverRepository.Save();
                FineList.Add(fine);
            }   
        }

        public DriverProfileVM(int idDriver)
        {
            if(idDriver != 0)
            {
                CurrentDriver = DriverRepository.GetById(idDriver);
                FineList.Clear();
                FineList.AddRange(CurrentDriver.Fines);
                return;
            }
        }
    }
}
