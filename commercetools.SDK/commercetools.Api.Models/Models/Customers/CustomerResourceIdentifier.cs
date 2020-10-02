using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("customer")]
    public partial class CustomerResourceIdentifier : ResourceIdentifier
    {
        public CustomerResourceIdentifier()
        { 
           this.TypeId = "customer";
        }
    }
}
