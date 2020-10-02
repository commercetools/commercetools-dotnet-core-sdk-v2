using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("customer")]
    public partial class CustomerReference : Reference
    {
        public Customer Obj { get; set;}
        public CustomerReference()
        { 
           this.TypeId = "customer";
        }
    }
}
