using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sozialweb.Models.Entity
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateInserted { get; set; }

        public ArrayList FriendsList { get; set; }
    }
}