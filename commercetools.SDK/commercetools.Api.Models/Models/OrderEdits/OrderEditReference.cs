using commercetools.Api.Models.Common;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("order-edit")]
    public class OrderEditReference : Reference
    {
        public OrderEdit Obj { get; set;}
    }
}
