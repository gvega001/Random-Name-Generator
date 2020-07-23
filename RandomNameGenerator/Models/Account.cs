
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomNameGenerator.Models 
{ 
    public class Account
    {
        public string Name { get; set; }
        public Guid accountId { get; private set; } = Guid.NewGuid();
        public string sisAccountId { get; set; }

    }
}