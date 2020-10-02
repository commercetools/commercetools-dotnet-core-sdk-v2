using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeTextLineItemName")]
    public partial class ShoppingListChangeTextLineItemNameAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Name { get; set;}
        public ShoppingListChangeTextLineItemNameAction()
        { 
           this.Action = "changeTextLineItemName";
        }
    }
}
