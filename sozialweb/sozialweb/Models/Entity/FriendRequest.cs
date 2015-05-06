using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sozialweb.Models.Entity
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
    }
}