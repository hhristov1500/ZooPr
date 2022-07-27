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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get;set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public byte[] Picture { get; set; }
       /* [ForeignKey("Category")]
        public int IdCat { get;set; }*/
        [ForeignKey("Category")]
        public int IdCat { get; set; }
        public virtual Category Category { get; set; }
    }
}
