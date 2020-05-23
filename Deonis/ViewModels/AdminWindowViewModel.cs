using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
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




        public AdminWindowViewModel(IUserManager UserManager)
        {
            ChangeVisibilityButtonCloseMenu = new RelayCommand(OnChangeVisibilityButtonCloseMenuExecuted, OnChangeVisibilityButtonCloseMenuExecute);
            ChangeVisibilityButtonOpenMenu = new RelayCommand(OnChangeVisibilityButtonOpenMenuExecuted, OnChangeVisibilityButtonOpenMenuExecute);

            ChangeVisibilityButtonCloseMenuButton = new RelayCommand(OnChangeVisibilityButtonCloseMenuButtonExecuted, OnChangeVisibilityButtonCloseMenuButtonExecute);
            ChangeVisibilityButtonOpenMenuButton = new RelayCommand(OnChangeVisibilityButtonOpenMenuButtonExecuted, OnChangeVisibilityButtonOpenMenuButtonExecute);

            this.UserManager = UserManager;
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
    }
}
