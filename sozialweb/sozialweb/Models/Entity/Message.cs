using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sozialweb.Models.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public int RecipientId { get; set; }
    }
}