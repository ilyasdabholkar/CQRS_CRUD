using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.Persistence.Models
{
    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Mobile { get; set; }

        [Required]
        public string? Address { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    }
}
