using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetStoreAction))]
    public partial interface IShoppingListSetStoreAction : IShoppingListUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }
    }
}
