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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemMoneyAction))]
    public partial interface ICartChangeCustomLineItemMoneyAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        IMoney Money { get; set; }

    }
}
