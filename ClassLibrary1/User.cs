using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Core.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Email { get; set; }

    }
}
