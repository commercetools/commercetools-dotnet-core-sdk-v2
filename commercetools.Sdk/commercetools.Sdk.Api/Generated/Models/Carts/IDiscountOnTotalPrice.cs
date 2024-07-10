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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountOnTotalPrice))]
    public partial interface IDiscountOnTotalPrice
    {
        ITypedMoney DiscountedAmount { get; set; }

        IList<IDiscountedTotalPricePortion> IncludedDiscounts { get; set; }
        IEnumerable<IDiscountedTotalPricePortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }


        ITypedMoney DiscountedNetAmount { get; set; }

        ITypedMoney DiscountedGrossAmount { get; set; }

    }
}
