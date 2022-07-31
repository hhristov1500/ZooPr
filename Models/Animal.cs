using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Animal
    {
        
       
        public Animal()
        {

        }
        public Animal(string name, string description, byte[] picture, int categoryId)
        {
            
            Name = name;
            Description = description;
            Picture = picture;
            IdCat = categoryId;
        }

        [Key]
        
        public int Id { get;set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public byte[] Picture { get; set; }
        [ForeignKey(nameof(Category))]
        public int IdCat { get; set; }
        public virtual Category Category { get; set; }


    }
}
