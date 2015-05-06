using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sozialweb.Models.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public int ParentId { get; set; }
        public string Body { get; set; }
        public DateTime DateInserted { get; set; }
    }
}