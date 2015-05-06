using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sozialweb.Models.Entity
{
    public class Status
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public DateTime DateInserted { get; set; }
    }
}