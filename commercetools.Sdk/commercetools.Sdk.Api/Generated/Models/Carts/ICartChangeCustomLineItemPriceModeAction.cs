using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemPriceModeAction))]
    public partial interface ICartChangeCustomLineItemPriceModeAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        ICustomLineItemPriceMode Mode { get; set; }

    }
}
