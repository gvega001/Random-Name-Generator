using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace siscloudbookService.DataObjects
{
    public class Admin 
    {
        public Guid User_id { get; private set; } = Guid.NewGuid();
       
        public string Account_id { get; set; }
      
        public string Role_id { get; set; }
        public string Role { get; set; }
      
    }
}