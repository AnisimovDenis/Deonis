using Deonis_lib.Entities;
using Deonis_lib.Services;
using Deonis_lib.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Deonis.ViewModels
{
    public class AdminWindowViewModel : ViewModelBase
    {
        private readonly IUserManager UserManager;
        private readonly IEmployeeManager EmployeeManager;
        private readonly ITicketManager TicketManager;
        private readonly IOrderManager OrderManager;




        private Visibility visibilityButtonCloseMenu = Visibility.Collapsed;

        public Visibility VisibilityButtonCloseMenu
        {
            get => visibilityButtonCloseMenu;
            set => Set(ref visibilityButtonCloseMenu, value);
        }

        private Visibility visibilityButtonOpenMenu = Visibility.Visible;

        public Visibility VisibilityButtonOpenMenu
        {
            get => visibilityButtonOpenMenu;
            set => Set(ref visibilityButtonOpenMenu, value);
        }

        public ICommand ChangeVisibilityButtonCloseMenu { get; }

        public ICommand ChangeVisibilityButtonOpenMenu { get; }




        private Visibility visibilityButtonCloseMenuButton = Visibility.Collapsed;

        public Visibility VisibilityButtonCloseMenuButton
        {
            get => visibilityButtonCloseMenuButton;
            set => Set(ref visibilityButtonCloseMenuButton, value);
        }

        private Visibility visibilityButtonOpenMenuButton = Visibility.Visible;

        public Visibility VisibilityButtonOpenMenuButton
        {
            get => visibilityButtonOpenMenuButton;
            set => Set(ref visibilityButtonOpenMenuButton, value);
        }

        public ICommand ChangeVisibilityButtonCloseMenuButton { get; }

        public ICommand ChangeVisibilityButtonOpenMenuButton { get; }




        private Visibility visibilityStackPanelAddUser = Visibility.Collapsed;

        public Visibility VisibilityStackPanelAddUser
        {
            get => visibilityStackPanelAddUser;
            set => Set(ref visibilityStackPanelAddUser, value);
        }

        private Visibility visibilityStackPanelEditUser = Visibility.Collapsed;

        public Visibility VisibilityStackPanelEditUser
        {
            get => visibilityStackPanelEditUser;
            set => Set(ref visibilityStackPanelEditUser, value);
        }

        public ICommand OnOpenDilogHostAddUser { get; }

        public ICommand OnOpenDilogHostEditUser { get; }





        private ObservableCollection<User> users;

        public ObservableCollection<User> Users
        {
            get => users;
            private set => Set(ref users, value);
        }

        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get => employees;
            private set => Set(ref employees, value);
        }

        private ObservableCollection<Ticket> tickets;

        public ObservableCollection<Ticket> Tickets
        {
            get => tickets;
            private set => Set(ref tickets, value);
        }

        private ObservableCollection<Order> orders;

        public ObservableCollection<Order> Orders
        {
            get => orders;
            private set => Set(ref orders, value);
        }

        public AdminWindowViewModel(IUserManager UserManager, IEmployeeManager EmployeeManager, ITicketManager TicketManager, IOrderManager OrderManager)
        {
            users = new ObservableCollection<User>(UserManager.GetAll());
            employees = new ObservableCollection<Employee>(EmployeeManager.GetAll());
            tickets = new ObservableCollection<Ticket>(TicketManager.GetAll());
            orders = new ObservableCollection<Order>(OrderManager.GetAll());


            ChangeVisibilityButtonCloseMenu = new RelayCommand(OnChangeVisibilityButtonCloseMenuExecuted, OnChangeVisibilityButtonCloseMenuExecute);
            ChangeVisibilityButtonOpenMenu = new RelayCommand(OnChangeVisibilityButtonOpenMenuExecuted, OnChangeVisibilityButtonOpenMenuExecute);

            ChangeVisibilityButtonCloseMenuButton = new RelayCommand(OnChangeVisibilityButtonCloseMenuButtonExecuted, OnChangeVisibilityButtonCloseMenuButtonExecute);
            ChangeVisibilityButtonOpenMenuButton = new RelayCommand(OnChangeVisibilityButtonOpenMenuButtonExecuted, OnChangeVisibilityButtonOpenMenuButtonExecute);

            OnOpenDilogHostAddUser = new RelayCommand(OnOpenDilogHostAddUserExecuted, OnOpenDilogHostAddUserExecute);
            OnOpenDilogHostEditUser = new RelayCommand(OnOpenDilogHostEditUserExecuted, OnOpenDilogHostEditUserExecute);


            this.UserManager = UserManager;
            this.EmployeeManager = EmployeeManager;
            this.TicketManager = TicketManager;
            this.OrderManager = OrderManager;
        }

        private bool OnChangeVisibilityButtonCloseMenuExecute() => true;

        private void OnChangeVisibilityButtonCloseMenuExecuted()
        {
            VisibilityButtonCloseMenu = Visibility.Collapsed;
            VisibilityButtonOpenMenu = Visibility.Visible;
        }

        private bool OnChangeVisibilityButtonOpenMenuExecute() => true;

        private void OnChangeVisibilityButtonOpenMenuExecuted()
        {
            VisibilityButtonCloseMenu = Visibility.Visible;
            VisibilityButtonOpenMenu = Visibility.Collapsed;
        }


        private bool OnChangeVisibilityButtonCloseMenuButtonExecute() => true;

        private void OnChangeVisibilityButtonCloseMenuButtonExecuted()
        {
            VisibilityButtonCloseMenuButton = Visibility.Collapsed;
            VisibilityButtonOpenMenuButton = Visibility.Visible;
        }

        private bool OnChangeVisibilityButtonOpenMenuButtonExecute() => true;

        private void OnChangeVisibilityButtonOpenMenuButtonExecuted()
        {
            VisibilityButtonCloseMenuButton = Visibility.Visible;
            VisibilityButtonOpenMenuButton = Visibility.Collapsed;
        }


        private bool OnOpenDilogHostAddUserExecute() => true;

        private void OnOpenDilogHostAddUserExecuted()
        {
            DialogHost.OpenDialogCommand.Execute(null, null);

            VisibilityStackPanelAddUser = Visibility.Visible;
            VisibilityStackPanelEditUser = Visibility.Collapsed;
        }

        private bool OnOpenDilogHostEditUserExecute() => true;

        private void OnOpenDilogHostEditUserExecuted()
        {
            DialogHost.OpenDialogCommand.Execute(null, null);

            VisibilityStackPanelAddUser = Visibility.Collapsed;
            VisibilityStackPanelEditUser = Visibility.Visible;
        }
    }
}
