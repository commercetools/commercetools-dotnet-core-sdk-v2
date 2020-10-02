using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setTextLineItemCustomType")]
    public partial class ShoppingListSetTextLineItemCustomTypeAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public ShoppingListSetTextLineItemCustomTypeAction()
        { 
           this.Action = "setTextLineItemCustomType";
        }
    }
}
