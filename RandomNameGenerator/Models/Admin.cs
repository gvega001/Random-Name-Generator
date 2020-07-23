using System;

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