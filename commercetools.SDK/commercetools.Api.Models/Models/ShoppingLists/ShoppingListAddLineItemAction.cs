using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("addLineItem")]
    public partial class ShoppingListAddLineItemAction : ShoppingListUpdateAction
    {
        public string Sku { get; set;}
        
        public string ProductId { get; set;}
        
        public long VariantId { get; set;}
        
        public long Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        public ShoppingListAddLineItemAction()
        { 
           this.Action = "addLineItem";
        }
    }
}
