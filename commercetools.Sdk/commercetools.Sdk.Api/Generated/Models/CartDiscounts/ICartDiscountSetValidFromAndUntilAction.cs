using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction))]
    public partial interface ICartDiscountSetValidFromAndUntilAction : ICartDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
