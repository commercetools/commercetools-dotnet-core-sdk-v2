using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction))]
    public partial interface IMyShoppingListChangeLineItemQuantityAction : IMyShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        long Quantity { get; set; }

    }
}
