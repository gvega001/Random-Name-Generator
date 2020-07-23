using System;

namespace RandomNameGenerator.Models
{
    public class Admin 
    {
        public Guid User_id { get; private set; } = Guid.NewGuid();
       
        public string Account_id { get; set; }
      
        public string Role_id { get; set; }
        public string Role { get; set; }
      
    }
}