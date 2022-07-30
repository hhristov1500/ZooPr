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
        private String _password;
        private ViewModelBase _selectedViewModel;
        private List<User> _users;
        public User currentUser;
        public List<User> Users { get; set; }
        //private ICommand _loginCommand;
       // public ICommand _updateView;
        public String Password
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

        public string Username { get { return _username; } set { _username = value; } }


        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        /*public ICommand UpdateView
        {
            get
            {
                return _updateView ?? (_updateView = new CommandHandler(() => updateAction(), () => CanExecute));
            }

        }
    public void updateAction()
        {

            SelectedViewModel = new TicketsViewModel(currentUser);

                    
            
        }
        public ICommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new CommandHandler(() => LoginAction(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }
        public void LoginAction()
        {
            if (String.IsNullOrEmpty(this.Username))
            {
                MessageBox.Show("Моля въведете име!");
            }
            else if (String.IsNullOrEmpty(this.Password))
            {
                MessageBox.Show("Моля въведете парола!");
            }
            else
            {

                currentUser = dBContext.User.FirstOrDefault(u => u.Name == this.Username && u.Password == this.Password);

                if (currentUser == null)
                {
                    MessageBox.Show("Грешни данни за вход!");
                }
                else
                {
                    SelectedViewModel = new MenuViewModel();
                    //UpdateViewCommand = new UpdateViewCommand(this,currentUser);
                }

            }
        
        }
       */
        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);


        }
    }
}
