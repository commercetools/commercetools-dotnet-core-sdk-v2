using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerCreatePasswordResetToken 
    {
        public string Email { get; set;}
        
        public long TtlMinutes { get; set;}
    }
}
