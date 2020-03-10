using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPlex.Models.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Code { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        public string Contact { get; set; }

        [Required]
        public int LoyaltyPoint { get; set; }

        public string Image { get; set; }
    }
}
