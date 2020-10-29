using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetTextLineItemCustomTypeAction : IShoppingListSetTextLineItemCustomTypeAction
    {
        public string Action { get; set;}
        
        public string TextLineItemId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public ShoppingListSetTextLineItemCustomTypeAction()
        { 
           this.Action = "setTextLineItemCustomType";
        }
    }
}
