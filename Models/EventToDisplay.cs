using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class EventToDisplay
    {
        public EventToDisplay()
        {
        }

        public EventToDisplay(string name,string desc,DateTime date,string type)
        {
            Name = name;
            Description = desc;
            Date = date;
            Type = type;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
        public string Type { get; set; }
    }
}
