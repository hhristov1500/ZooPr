using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zoo.Models;
using Zoo.View_Models;

namespace Zoo.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;
        private User sUser;
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
            //this.sUser = user;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            switch (parameter)
            {
                case "Menu":
                    //ValidateLogin();
                   
                        viewModel.SelectedViewModel = new MenuViewModel();
                   
                    break;
                case "Animals":
                    viewModel.SelectedViewModel = new AnimalViewModel();

                    break;
                case "Events":
                    viewModel.SelectedViewModel = new EventsViewModel();

                    break;
                case "Tickets":
                   
                        viewModel.SelectedViewModel = new TicketsViewModel(sUser);
                        break;
                default:
                    break;
            }
            
        }
        /*public void ValidateLogin()
        {
            
         sUser = viewModel.Users.Find(u => u.Name == viewModel.Username && viewModel.Password == u.Password);
            
            
            
        }*/
    }
}
