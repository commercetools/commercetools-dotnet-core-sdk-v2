using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setLineItemCustomType")]
    public partial class ShoppingListSetLineItemCustomTypeAction : ShoppingListUpdateAction
    {
        public string LineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public ShoppingListSetLineItemCustomTypeAction()
        { 
           this.Action = "setLineItemCustomType";
        }
    }
}
