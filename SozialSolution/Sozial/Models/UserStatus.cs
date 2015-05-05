using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Sozial.Models
{
    public class UserStatus
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public DateTime DateInsert { get; set; }
        public string User { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
