using System;
using System.Windows.Input;
using FinesApp.UI.App.Utilities;

namespace FinesApp.UI.App.ViewModel
{
    public class NavigationVM : ViewModelBase
    {
        public static int idDriver = 0;

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand DriverSearchCommand { get; set; }
        public ICommand DriverProfileCommand { get; set; }
        public ICommand IssuingFineCommand { get; set; }
        public ICommand MiolationsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        public void Home(object obj) => CurrentView = new HomeVM();
        public void DriverProfile(object obj) => CurrentView = new DriverProfileVM(idDriver);
        public void DriverSearch(object obj) => CurrentView = new DriverSearchVM();
        public void Miolations(object obj) => CurrentView = new MiolationsVM();
        public void Settings(object obj) => CurrentView = new SettingsVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            DriverSearchCommand = new RelayCommand(DriverSearch);
            DriverProfileCommand = new RelayCommand(DriverProfile);
            MiolationsCommand = new RelayCommand(Miolations);
            SettingsCommand = new RelayCommand(Settings);

            // Startup Page 
            CurrentView = new HomeVM();
        }
    }
}
