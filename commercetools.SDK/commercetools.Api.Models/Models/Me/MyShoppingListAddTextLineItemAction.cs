using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addTextLineItem")]
    public partial class MyShoppingListAddTextLineItemAction : MyShoppingListUpdateAction
    {
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public long Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        public MyShoppingListAddTextLineItemAction()
        { 
           this.Action = "addTextLineItem";
        }
    }
}
