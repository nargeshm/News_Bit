using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Core.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }
        public List<News> News { get; set; }
    }
}
