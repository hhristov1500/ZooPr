using Syncfusion.Windows.Shared;
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
        private List<EventToDisplay> _events;
        private DateTime? _sDate=null;
        private ICommand _searchEvents;
        private EventToDisplay _sEvent;
        
        public ICommand SearchEvents
        {
            get
            {
                return _searchEvents ?? (_searchEvents = new DelegateCommand(context =>
                {
                    SearchAction();
                }));
            }
        }
        

        public void SearchAction()
        {
            //checks if date is null or not and checks if the type for event chosen by the user is null or not
            //then selects the events by the condition
            if (SDate != null && SEventsType == null)
            {
                /*Events = zooDbContext.Event.Where(e => e.Date == SDate).
              Select(e => e).ToList();*/
                Events = (from Event in zooDbContext.Event
                             join EventsType in zooDbContext.EventsType on Event.IdType equals EventsType.IdType
                             where  Event.Date == SDate
                             select new EventToDisplay() { Name = Event.Name, Description = Event.Description, Date = Event.Date, Type = EventsType.Type }).ToList();
                
            }
            else if(SDate == null && SEventsType != null)
            {
                /*Events = zooDbContext.Event.Where(e => e.IdType == SEventsType.IdType).
                Select(e => e).ToList();*/
                Events = (from Event in zooDbContext.Event
                             join EventsType in zooDbContext.EventsType on Event.IdType equals EventsType.IdType
                             where Event.IdType == SEventsType.IdType 
                             select new EventToDisplay() { Name = Event.Name, Description = Event.Description, Date = Event.Date, Type = EventsType.Type }).ToList();
                
            }
            else if(SDate != null && SEventsType != null)
            {
                /*Events = zooDbContext.Event.Where(e => e.IdType == SEventsType.IdType && e.Date == SDate).
                     Select(e=>e).ToList();*/
                Events  = (from Event in zooDbContext.Event
                            join EventsType in zooDbContext.EventsType on Event.IdType equals EventsType.IdType
                            where Event.IdType == SEventsType.IdType && Event.Date == SDate
                            select new EventToDisplay(){Name=Event.Name,Description=Event.Description,Date=Event.Date, Type=EventsType.Type }).ToList();
              
            }
            else
            {
                Events = (from Event in zooDbContext.Event
                             join EventsType in zooDbContext.EventsType on Event.IdType equals EventsType.IdType
                             select new EventToDisplay() { Name = Event.Name, Description = Event.Description, Date = Event.Date, Type = EventsType.Type }).ToList();
                
            }
        }

            public void DisplayEventType()
        {
            //Displays all types of events in combobox
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
        public List<EventToDisplay> Events
        {
            get { return _events; }
            set {
                _events = value;
               OnPropertyChanged("Events");
            }
        }
        public EventToDisplay SEvent
        {
            get
            {
                return _sEvent;
            }
            set { _sEvent = value;
                OnPropertyChanged("SEvent");
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
