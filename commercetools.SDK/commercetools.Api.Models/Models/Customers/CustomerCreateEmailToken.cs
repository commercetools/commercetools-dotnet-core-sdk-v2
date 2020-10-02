using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerCreateEmailToken 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public long TtlMinutes { get; set;}
    }
}
