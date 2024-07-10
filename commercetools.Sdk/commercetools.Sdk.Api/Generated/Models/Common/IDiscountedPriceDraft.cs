using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.DiscountedPriceDraft))]
    public partial interface IDiscountedPriceDraft
    {
        IMoney Value { get; set; }

        IProductDiscountReference Discount { get; set; }

    }
}
