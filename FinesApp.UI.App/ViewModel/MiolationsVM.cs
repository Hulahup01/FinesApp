using FinesApp.Domain.Entities;
using FinesApp.Domain.Constants;
using FinesApp.Infrastructure.Data.Repositories;
using FinesApp.UI.App.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FinesApp.Infrastructure.Data.Contexts;
using FInesApp.Constants;

namespace FinesApp.UI.App.ViewModel
{
    internal class MiolationsVM: ViewModelBase
    {
        public static ObservableRangeCollection<TypeOfMiolation> MiolationsList { get; set; }
        private static ViolationRepository MiolationRepository { get; set; }
        static bool ListAndRepoInitialized = false;
        static bool LS = true;
        public MiolationsVM()
        {
            if(LS)
            {
                LS = false;
                MiolationsList = new();
            }
        }
      
        public static async Task ConfigureAndInitRepositoryAsync()
        {
            if (ListAndRepoInitialized)
                return;

            await Task.Run(async () =>
            {
                ListAndRepoInitialized = true;
                var builder = new DbContextOptionsBuilder<MiolationDbContext>();
                var options = builder.UseLazyLoadingProxies().UseSqlite("Data Source=MiolationsDB.db").Options;
                MiolationRepository = new ViolationRepository(options);

                await MiolationRepository.InitializeAsync();               
                
                var temp = await MiolationRepository.GetListAsync();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MiolationsList.AddRange(temp);
                });
            });
        }
      
    }
}
