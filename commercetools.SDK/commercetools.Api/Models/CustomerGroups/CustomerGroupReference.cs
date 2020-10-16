using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("customer-group")]
    public partial class CustomerGroupReference : Reference
    {
        public CustomerGroup Obj { get; set;}
        public CustomerGroupReference()
        { 
           this.TypeId = "customer-group";
        }
    }
}
