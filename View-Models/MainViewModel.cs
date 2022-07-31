using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Data;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class MainViewModel : ViewModelBase
    {
        public ZooDbContext dBContext = new ZooDbContext();
        private string _username;
        private string _password;
        private ViewModelBase _selectedViewModel;
        private List<User> _users;
        public User currentUser;
        public List<User> Users { get; set; }
     
        public string Password
        {
            get { return _password; }
            set
            {
                if (value != null)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string Username { get { return _username; } set { _username = value; OnPropertyChanged("Username"); } }


        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }



        public int  ValidateUser()
        {
            if (Username != null && Password != null)
                return dBContext.User.FirstOrDefault(u => u.Name == this.Username && u.Password == this.Password).IdUser;
            return 0;
        }
        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);


        }
    }
}
