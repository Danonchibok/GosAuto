﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private ObservableObject curretnView;

        private bool isLogged;//pole
        public bool IsLogged //cvoystvo
        {
            get => isLogged;
            set
            {
                isLogged = value;
                OnPropertyChanged("IsLogged");
            }
        }
        public ObservableObject CurrentView
        {
            get => curretnView;
            set
            {
                curretnView = value;
                OnPropertyChanged("CurrentView");
            }
        }
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand DriversCommand { get; set; }
        public RelayCommand CreateDriversCommand { get; set; }
        public RelayCommand LicencesCommand { get; set; }
        public RelayCommand MainInfoCommand { get; set; }



        public AuthViewModel AuthVM { get; set; }
        public AddDriverViewModel AddDriverVM { get; set; }
        public DriversListViewModel DriversListVM { get; set; }
        public LicencesListViewModel LicencesListVM{ get; set; }
        public MainInfoPageViewModel MainInfoPageVM { get; set; }
 
        public MainViewModel()
        {
            IsLogged = false; //Потом сменить false
            AuthVM = new AuthViewModel();
            AddDriverVM = new AddDriverViewModel();
            DriversListVM = new DriversListViewModel();
            LicencesListVM = new LicencesListViewModel();
            MainInfoPageVM = new MainInfoPageViewModel();

            curretnView = AuthVM;

            AuthVM.LoginEvent += AuthVM_LoginEvent;
            LicencesListVM.DriversCardEvent += LicencesListVM_DriversCardEvent;


            ExitCommand = new RelayCommand(o =>
            {
                CurrentView = AuthVM;
                IsLogged = false;
            });

            DriversCommand = new RelayCommand(o =>
            {
                CurrentView = DriversListVM;
            });

            LicencesCommand = new RelayCommand(o =>
            {
                CurrentView = LicencesListVM;
            });

            CreateDriversCommand = new RelayCommand(o =>
            {   
               CurrentView = AddDriverVM;
            });

            MainInfoCommand = new RelayCommand(o =>
            {
                CurrentView = MainInfoPageVM;
            });
           

        }

        private void LicencesListVM_DriversCardEvent(object sender, EventArgs e)
        {
            CurrentView = LicencesListVM.AddNewLicenceVM;
        }

        private void AuthVM_LoginEvent(object sender, EventArgs e)
        {
            IsLogged = true;
            CurrentView = MainInfoPageVM;
        }
    }
}
