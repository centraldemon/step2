using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength:225)]
        public string  Login { get; set; }
        [Required,StringLength(maximumLength:225)]
        public string Password { get; set; }

    }
}
