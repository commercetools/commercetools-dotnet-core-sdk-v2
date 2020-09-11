using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerCreatePasswordResetToken 
    {
        public string Email { get; set;}
        
        public long TtlMinutes { get; set;}
    }
}
