using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetLineItemCustomTypeAction : IShoppingListSetLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ShoppingListSetLineItemCustomTypeAction()
        {
            this.Action = "setLineItemCustomType";
        }
    }
}
