using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removeCustomLineItem")]
    public class CartRemoveCustomLineItemAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
    }
}
