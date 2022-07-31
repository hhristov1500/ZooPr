using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zoo.Data;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class TicketsViewModel : ViewModelBase
    {
        private ZooDbContext zooDbContext = new ZooDbContext();
        private List<TicketsType> _ticketsTypes;
        private List<Ticket> _ticketsList;
        private List<Ticket> _ticketsDisplay;
        private TicketsType _sType;
        private Ticket ticket;
        private double _sValue;
        private double _finalPrice;
        private int currUserId;

        private ICommand _saveTicketsToDb;
        private ICommand _displayTicketsOnTable;
        
        public double FinalPrice { get { return _finalPrice; } set { _finalPrice = value; OnPropertyChanged("FinalPrice"); } }
        public TicketsViewModel(int userId)
        {
            DisplayTicketsType();
            currUserId = userId;
            _ticketsList = new List<Ticket>();
            FinalPrice = 0;
        }
        
        public void DisplayTicketsType()
        {
            //displays all types of tickets in a combobox
            TicketsTypes = zooDbContext.TicketsType.Select(t => t).ToList(); 
        }


        /* public ICommand SaveTicketsToDb //not done yet
         {
             get
             {
                 return _saveTicketsToDb ?? (_saveTicketsToDb = new DelegateCommand(context => SaveAction()));
             }
         }*/
        public void SaveAction()
        {
            //not done yet
            /*if (TicketsList.Count != 0)
            {
                for(int i = 0; i < TicketsList.Count; i++)
                {
                    UserOrdercs order = new UserOrdercs();
                    order.IdUser = currUser.IdUser;
                    if(TicketsList[i].Type=="Индивидуален")
                    order.IdTypeTicket = 1;
                    zooDbContext.UserOrdercs.Add(order);
                    zooDbContext.SaveChanges();
                }
                
            }*/
        }
        public ICommand DisplayTicketsOnTable
        {
            get
            {
                return _displayTicketsOnTable ?? (_displayTicketsOnTable = new DelegateCommand(context => MyAction()));
            }
        }
        public void MyAction()
        {
            if (SType != null){
                if ((int)SValue!=0)
                {
                    Ticket = new Ticket();
                    Ticket.Type = SType.Type;
                    Ticket.Price = SType.price;
                    Ticket.Number = (int)SValue;
                    TicketsList.Add(Ticket);
                    TicketsDisplay = new List<Ticket>(TicketsList);
                    FinalPrice += SType.price * SValue;
                }
                else { MessageBox.Show("Броят на билетите не може да бъде по-малък от 1!"); }

            }
            else
            {
                MessageBox.Show("Моля изберете тип на билета!");
            }
            
           
        }
       

        public List<TicketsType> TicketsTypes
        {
            get { return _ticketsTypes; }
            set
            {
                _ticketsTypes = value;
                OnPropertyChanged("TicketsTypes");
            }
        }
        public List<Ticket> TicketsList
        {
            get { return _ticketsList; }
            set
            {
                _ticketsList = value;
                OnPropertyChanged("TicketsList");
            }
        }
        public List<Ticket> TicketsDisplay
        {
            get { return _ticketsDisplay; }
            set
            {
                _ticketsDisplay = value;
                OnPropertyChanged("TicketsDisplay");
            }
        }
        public Ticket Ticket
        {
            get { return ticket; }
            set { ticket = value; 
                OnPropertyChanged("Ticket");
            }
        }
        public TicketsType SType
        {
            get { return _sType; }
            set { _sType = value;
                OnPropertyChanged("SType");
                
            }
        }
        public double SValue
        {
            get { return _sValue; }
            set {_sValue = value;
                OnPropertyChanged("SValue");
                
            }
        }
    }
}
