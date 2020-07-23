
using System;

namespace RandomNameGenerator.Models 
{ 
    public class Account
    {
        public string Name { get; set; }
        public Guid accountId { get; private set; } = Guid.NewGuid();
        public string sisAccountId { get; set; }

    }
}