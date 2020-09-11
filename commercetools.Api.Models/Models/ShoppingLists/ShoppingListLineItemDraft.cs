using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListLineItemDraft 
    {
        public DateTime AddedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Sku { get; set;}
        
        public string ProductId { get; set;}
        
        public int Quantity { get; set;}
        
        public long VariantId { get; set;}
    }
}
