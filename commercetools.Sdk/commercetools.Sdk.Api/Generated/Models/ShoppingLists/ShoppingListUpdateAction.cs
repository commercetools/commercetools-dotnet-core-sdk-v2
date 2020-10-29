using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public abstract partial class ShoppingListUpdateAction : IShoppingListUpdateAction
    {
        public string Action { get; set;}
    }
}
