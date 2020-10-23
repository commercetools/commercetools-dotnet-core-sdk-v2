using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingListSetSlugAction : IShoppingListUpdateAction
    {
        ILocalizedString Slug { get; set;}
    }
}
