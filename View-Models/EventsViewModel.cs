using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Data;
using Zoo.Models;

namespace Zoo.View_Models
{
    public class EventsViewModel : ViewModelBase
    {
        private ZooDbContext zooDbContext = new ZooDbContext();
        private List<EventsType> _eventTypes;
        private EventsType _sEventsType;
        private List<Event> _events;
        private DateTime? _sDate=null;
        private ICommand _searchEvents;

        public ICommand SearchEvents
        {
            get
            {
                return _searchEvents ?? (_searchEvents = new CommandHandler(() => SearchAction(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public void SearchAction()
        {
            if (SDate != null && SEventsType == null)
            {
                Events = zooDbContext.Event.Where(e => e.Date == SDate).
              Select(e => e).ToList();
            }
            else if(SDate == null && SEventsType != null)
            {
                Events = zooDbContext.Event.Where(e => e.IdType == SEventsType.IdType).
                Select(e => e).ToList();
            }
            else if(SDate != null && SEventsType != null)
            {
                Events = zooDbContext.Event.Where(e => e.IdType == SEventsType.IdType && e.Date == SDate).
                     Select(e=>e).ToList();
                /*Events =
                (List<EventToDisplay>)(IEnumerable<EventToDisplay>)(from Event in zooDbContext.Event
                join EventsType in zooDbContext.EventsType on Event.IdType equals EventsType.IdType
                where Event.IdType == SEventsType.IdType && Event.Date == SDate
                select new { Event.Name,Event.Date,EventsType.Type}).ToList();*/


            }
            else
            {
                Events = zooDbContext.Event.
                  Select(e => e).ToList();
            }
        }

            public void DisplayEventType()
        {
            EventTypes = zooDbContext.EventsType.Select(t => t).ToList();
        }

        public EventsType SEventsType
        {
            get { return _sEventsType; }
            set
            {
                _sEventsType = value;
                OnPropertyChanged("SEventsType");

            }
        }
        public DateTime? SDate
        {
            get { return _sDate; }
            set
            {
                _sDate = value;
                OnPropertyChanged("SDate");
            }
        }
        public List<Event> Events
        {
            get { return _events; }
            set {
                _events = value;
               OnPropertyChanged("Events");
            }
        }
        
        public List<EventsType> EventTypes
        {
            get { return _eventTypes; }
            set
            {
                _eventTypes = value;
                OnPropertyChanged("EventTypes");
            }
        }
        public EventsViewModel()
        {
            DisplayEventType();
        }
    }
}
