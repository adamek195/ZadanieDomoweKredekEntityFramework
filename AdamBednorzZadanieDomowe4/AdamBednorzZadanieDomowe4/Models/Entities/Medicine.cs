using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdamBednorzZadanieDomowe4.Models.Entities
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MedicineName { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
