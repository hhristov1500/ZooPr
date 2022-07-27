using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class TicketsType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
