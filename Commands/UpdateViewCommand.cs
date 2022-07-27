using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zoo.View_Models;

namespace Zoo.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
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
                    if (viewModel.Username == viewModel.User.Name)
                        viewModel.SelectedViewModel = new MenuViewModel();
                    else MessageBox.Show("Грешни данни");
                    break;
                case "Animals":
                    viewModel.SelectedViewModel = new AnimalViewModel();

                    break;
                case "Events":
                    viewModel.SelectedViewModel = new EventsViewModel();

                    break;
                case "Tickets":
                    viewModel.SelectedViewModel = new TicketsViewModel(viewModel.User);

                    break;
                default:
                    break;
            }
            
        }
        public bool ValidateLogin()
        {
           /// if(viewModel.SelectedViewModel == null)
            return false;
        }
    }
}
