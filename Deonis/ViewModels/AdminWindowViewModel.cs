using Deonis_lib.Entities;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis.ViewModels
{
    public class AdminWindowViewModel : ViewModelBase
    {
        private User selectedUser;
        public User SelectedUser
        {
            get => selectedUser;
            set => Set(ref selectedUser, value);
        }

        public AdminWindowViewModel()
        {

        }
    }
}
