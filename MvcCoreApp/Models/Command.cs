using System;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcCoreApp.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("How to")]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
