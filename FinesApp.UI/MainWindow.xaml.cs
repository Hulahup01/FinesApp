using System;
using System.Windows;
using FinesApp.Infrastructure.Data.Repositories;
using FinesApp.Domain.Interfaces.Repositories;
using FinesApp.Domain.Entities;
using FinesApp.Domain.Constants;
using FinesApp.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Windows.Media;
using FInesApp.Constants;

namespace FinesApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public IRepository<TypeOfMiolation> repo;
        //IReadOnlyList<TypeOfMiolation> list;
        //IReadOnlyList<Driver> listD;
        //DriverRepository driverRepository;
        //MiolationRepository repo;

        public MainWindow()
        {
            InitializeComponent();
            //var builder = new DbContextOptionsBuilder<MiolationDbContext>();
            //var options = builder.UseSqlite("Data Source=Drivers_DB.db").Options;
            //repo = new MiolationRepository(options);
            //TypeOfMiolation miol = new TypeOfMiolation("18.8.", "2", "Открытие дверей транспортного средства во время движения");
            ////ff();

            //var builder = new DbContextOptionsBuilder<AppDbContext>();
            //var options = builder.UseLazyLoadingProxies().UseSqlite("Data Source=DriversDB.db").Options;
            //driverRepository = new DriverRepository(options);


            //RegistrationCertificate cert = new RegistrationCertificate("numb", "regsign", "bModel", 2015, CarColors.RED, "bFrame", "vType", 2000, DateTime.Today);
            //List<RegistrationCertificate> lRC = new();
            //lRC.Add(cert);
            //DriversLicense drlic = new DriversLicense("sNumb", "firstName", "lastneme", "patr", DateTime.Now, "plb", "issB", DateTime.Now, DateTime.Now, Categories.B);
            //Fine fine = new Fine(DateTime.Now, DateTime.Now, miol, "pLfI", "d", 1);
            //List<Fine> lF = new List<Fine>();
            //lF.Add(fine);
            //Driver dr = new Driver("fn","ln","patr", "gend", DateTime.Now, "plac", drlic, lRC, lF);
            ////ff();
            //driverRepository.Add(dr);
            //driverRepository.Save();
            ////repo.Add(miol);
            ////repo.Save();
            //var fl = driverRepository.GetList();
            //var ll = driverRepository.GetById(8);
            //ff();
          
        }

        //public async void ff()
        //{
        //    listD = await driverRepository.GetListAsync();
        //}


    }
}
