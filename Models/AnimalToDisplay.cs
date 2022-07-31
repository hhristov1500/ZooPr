using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class AnimalToDisplay
    {
        //used when displaying animal in animal view 
        
        public AnimalToDisplay()
        {
        }

        public AnimalToDisplay(string name, string desc, byte[] image, string category)
        {
            Name = name;
            Description = desc;
            Image = image;
            Category = category;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public string Category { get; set; }
    }
}
