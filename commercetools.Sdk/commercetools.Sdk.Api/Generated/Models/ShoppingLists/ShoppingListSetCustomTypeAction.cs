using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setCustomType")]
    public partial class ShoppingListSetCustomTypeAction : ShoppingListUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public ShoppingListSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
