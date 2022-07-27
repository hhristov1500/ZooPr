using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class TicketsViewModel : ViewModelBase
    {
        private User _user;
        public User User => _user;
        public TicketsViewModel(User user)
        {
            _user = user;
            Console.WriteLine(User);
        }
    }
}
