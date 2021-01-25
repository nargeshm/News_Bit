using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Core.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public string PassWord { get; set; }
        [Required]
        public string Email { get; set; }

        public List<News> News { get; set; }

    }
}
