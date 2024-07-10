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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedPrice))]
    public partial interface ITaxedPrice
    {
        ICentPrecisionMoney TotalNet { get; set; }

        ICentPrecisionMoney TotalGross { get; set; }

        IList<ITaxPortion> TaxPortions { get; set; }
        IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }


        ICentPrecisionMoney TotalTax { get; set; }

    }
}
