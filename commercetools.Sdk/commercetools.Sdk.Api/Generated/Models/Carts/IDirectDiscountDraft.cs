using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DirectDiscountDraft))]
    public partial interface IDirectDiscountDraft
    {
        ICartDiscountValueDraft Value { get; set; }

        ICartDiscountTarget Target { get; set; }

    }
}
