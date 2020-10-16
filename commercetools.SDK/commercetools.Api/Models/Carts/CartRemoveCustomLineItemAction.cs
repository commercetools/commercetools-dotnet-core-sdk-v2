using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removeCustomLineItem")]
    public partial class CartRemoveCustomLineItemAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        public CartRemoveCustomLineItemAction()
        { 
           this.Action = "removeCustomLineItem";
        }
    }
}
