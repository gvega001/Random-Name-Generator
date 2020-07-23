using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace siscloudbookService.DataObjects
{
    public class User 
    {
       
        public string User_id { get; set; }
        //[ForeignKey("User_id")]
        public string Integration_id { get; set; }
        public string Login_id { get; set; }
        public string Password { get; set; }
        public string Ssha_password { get; set; }
        public string Authentication_provider_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Full_name { get; set; }
        public string Sortable_name { get; set; }
        public string Short_name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}