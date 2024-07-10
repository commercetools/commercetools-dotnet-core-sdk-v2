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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedPriceDraft))]
    public partial interface ITaxedPriceDraft
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

        IList<ITaxPortionDraft> TaxPortions { get; set; }
        IEnumerable<ITaxPortionDraft> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }


        ITypedMoneyDraft TotalTax { get; set; }

    }
}
