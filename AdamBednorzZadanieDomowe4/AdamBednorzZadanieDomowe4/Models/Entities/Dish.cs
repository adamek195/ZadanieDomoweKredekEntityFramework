using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdamBednorzZadanieDomowe4.Models.Entities
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DishName { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
