using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("customer-group")]
    public partial class CustomerGroupResourceIdentifier : ResourceIdentifier
    {
        public CustomerGroupResourceIdentifier()
        { 
           this.TypeId = "customer-group";
        }
    }
}
