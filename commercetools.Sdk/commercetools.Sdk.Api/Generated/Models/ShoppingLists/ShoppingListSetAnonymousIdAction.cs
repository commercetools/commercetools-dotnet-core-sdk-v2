using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetAnonymousIdAction : IShoppingListSetAnonymousIdAction
    {
        public string Action { get; set; }

        public string AnonymousId { get; set; }
        public ShoppingListSetAnonymousIdAction()
        {
            this.Action = "setAnonymousId";
        }
    }
}
