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

    public partial class ShoppingListSetDescriptionAction : IShoppingListSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public ShoppingListSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
