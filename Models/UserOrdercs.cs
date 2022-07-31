using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class UserOrdercs
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int IdUser { get; set; }
        [ForeignKey(nameof(TicketsType))]
        public int IdTypeTicket { get; set; }

        public virtual TicketsType TicketsType { get; set; }

        public virtual User User { get; set; }
    }
}
