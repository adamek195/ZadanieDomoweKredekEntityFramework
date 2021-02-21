using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.Models.Entities
{
    public class InformationHospital
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string HospitalName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
    }
}
