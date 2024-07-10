using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetSlugAction : IShoppingListSetSlugAction
    {
        public string Action { get; set; }

        public ILocalizedString Slug { get; set; }
        public ShoppingListSetSlugAction()
        {
            this.Action = "setSlug";
        }
    }
}
