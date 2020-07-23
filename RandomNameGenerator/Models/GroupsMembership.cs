using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace siscloudbookService.DataObjects
{
    public class GroupsMembership : EntityData
    {
        public string Group_id { get; set; }
        //[ForeignKey("Group_id")]
        public string User_id { get; set; }
        public bool Accepted { get; set; }
        public bool GroupsMembershipDeleted { get; set;  }
      
    }
}