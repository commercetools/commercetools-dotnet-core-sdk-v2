using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addLineItem")]
    public partial class MyShoppingListAddLineItemAction : MyShoppingListUpdateAction
    {
        public string Sku { get; set;}
        
        public string ProductId { get; set;}
        
        public long VariantId { get; set;}
        
        public long Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        public MyShoppingListAddLineItemAction()
        { 
           this.Action = "addLineItem";
        }
    }
}
