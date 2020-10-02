using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setTextLineItemDescription")]
    public partial class ShoppingListSetTextLineItemDescriptionAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Description { get; set;}
        public ShoppingListSetTextLineItemDescriptionAction()
        { 
           this.Action = "setTextLineItemDescription";
        }
    }
}
