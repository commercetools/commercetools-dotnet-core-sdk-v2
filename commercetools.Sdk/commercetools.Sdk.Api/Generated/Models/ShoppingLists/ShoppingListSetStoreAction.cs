using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetStoreAction : IShoppingListSetStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public ShoppingListSetStoreAction()
        {
            this.Action = "setStore";
        }
    }
}
