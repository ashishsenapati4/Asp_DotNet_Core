using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginFormAsp6.Models
{
    public partial class UsrTbl
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string? Gender { get; set; }

        [Required]
        public int? Age { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
