using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeLineItemQuantityAction))]
    public partial interface ICartChangeLineItemQuantityAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        long Quantity { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

    }
}
