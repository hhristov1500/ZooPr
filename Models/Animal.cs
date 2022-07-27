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
        
        private int _id;
        private String _name;
        private String _description;
        private byte[] _picture;
        private int _categoryId;

        [Key]
        public int Id { get;set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public byte[] Picture { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryID { get;set; }
}
}
