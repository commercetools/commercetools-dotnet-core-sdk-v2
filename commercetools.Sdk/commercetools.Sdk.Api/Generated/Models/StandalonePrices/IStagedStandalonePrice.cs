using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StagedStandalonePrice))]
    public partial interface IStagedStandalonePrice
    {
        ITypedMoney Value { get; set; }

        IDiscountedPrice Discounted { get; set; }

    }
}
