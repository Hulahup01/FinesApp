using System;
using FinesApp.Domain.Entities;
using System.Collections.Generic;
using FinesApp.Infrastructure.Data.Repositories;
using FinesApp.Infrastructure.Data.Contexts;
using FinesApp.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.ObjectModel;
using FinesApp.UI.App.Utilities;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Threading;

namespace FinesApp.UI.App.ViewModel
{
    public class DriverSearchVM: ViewModelBase
    {
        public static ObservableRangeCollection<Driver> DriversList { get; set; }
        private static DriverRepository DriverRepository { get; set; }
        public ICommand RefreshCommand { get; }
        static bool DriverListInitialized = true;
        static bool onRepConfigurated = false;
        static bool DONE = true;

        public DriverSearchVM()
        {
            if (DriverListInitialized)
            {
                DriverListInitialized = false;
                DriversList = new();
            }
            RefreshCommand = new RelayCommand(ExecuteRefreshCommand);
        }
        
        private static async Task ConfigureRepositoryAsync()
        {
            await Task.Run(async () =>
            {
                var builder = new DbContextOptionsBuilder<AppDbContext>();
                var options = builder.UseLazyLoadingProxies().UseSqlite("Data Source=DriversDB.db").Options;
                DriverRepository = new DriverRepository(options);

                await DriverRepository.InitializeAsync();
                DriverProfileVM.DriverRepository = DriverRepository;
            });
        }

        public static async void ExecuteRefreshCommand(object param)
        {
            if (!DONE)
                return;

            await Task.Run(async () =>
            {
                DONE = false;
                if(!onRepConfigurated)
                {
                    await ConfigureRepositoryAsync();
                }
                var ff = await DriverRepository.GetListAsync();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    DriversList.Clear();
                    DriversList.AddRange(ff);
                });             
            });

            DONE = true;
        }      
    }
}
