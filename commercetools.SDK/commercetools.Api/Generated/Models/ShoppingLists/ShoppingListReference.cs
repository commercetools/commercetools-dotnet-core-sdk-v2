using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("shopping-list")]
    public partial class ShoppingListReference : Reference
    {
        public ShoppingList Obj { get; set;}
        public ShoppingListReference()
        { 
           this.TypeId = "shopping-list";
        }
    }
}
