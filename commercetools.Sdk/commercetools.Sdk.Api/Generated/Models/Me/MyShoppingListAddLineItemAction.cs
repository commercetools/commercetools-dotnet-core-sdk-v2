using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListAddLineItemAction : IMyShoppingListAddLineItemAction
    {
        public string Action { get; set;}
        
        public string Sku { get; set;}
        
        public string ProductId { get; set;}
        
        public long? VariantId { get; set;}
        
        public long? Quantity { get; set;}
        
        public DateTime? AddedAt { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        public MyShoppingListAddLineItemAction()
        { 
           this.Action = "addLineItem";
        }
    }
}
