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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ExternalLineItemTotalPrice))]
    public partial interface IExternalLineItemTotalPrice
    {
        IMoney Price { get; set; }

        IMoney TotalPrice { get; set; }

    }
}
