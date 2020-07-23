using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace siscloudbookService.DataObjects
{
    public class Admin 
    {
        public string User_id { get; set; }
       
        public string Account_id { get; set; }
      
        public string Role_id { get; set; }
        public string Role { get; set; }
        public string Root_account { get; set; }
    }
}