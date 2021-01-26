using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Core.Entities
{
    public class Media
    {
        public int MediaId { get; set; }
        public string Path { get; set; }
        public string Order { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}
