using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setKey")]
    public class OrderEditSetKeyAction : OrderEditUpdateAction
    {
        public string Key { get; set;}
    }
}
