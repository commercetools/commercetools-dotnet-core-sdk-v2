using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderExcerpt))]
    public partial interface IOrderExcerpt
    {
        ITypedMoney TotalPrice { get; set; }

        ITaxedPrice TaxedPrice { get; set; }

        long Version { get; set; }

    }
}
