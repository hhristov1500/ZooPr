using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Commands;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class MainViewModel : ViewModelBase
    {
        private string username;
        private string password;
        private User user = new User("Ivan");
        
        public User User { get { return user; } }
        public string Username { get { return username; } set { username = value; } }
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
