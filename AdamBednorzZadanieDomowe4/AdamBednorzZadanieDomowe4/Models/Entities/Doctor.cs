using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdamBednorzZadanieDomowe4.Models.Entities
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Date { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
