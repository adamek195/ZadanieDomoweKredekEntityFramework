using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Models.Entities
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
