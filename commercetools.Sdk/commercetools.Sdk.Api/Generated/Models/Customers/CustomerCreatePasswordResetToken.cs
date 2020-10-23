using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public  partial class CustomerCreatePasswordResetToken : ICustomerCreatePasswordResetToken
    {
        public string Email { get; set;}
        
        public long TtlMinutes { get; set;}
    }
}
