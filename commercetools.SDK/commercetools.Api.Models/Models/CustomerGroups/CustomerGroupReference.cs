using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("customer-group")]
    public class CustomerGroupReference : Reference
    {
        public CustomerGroup Obj { get; set;}
    }
}
