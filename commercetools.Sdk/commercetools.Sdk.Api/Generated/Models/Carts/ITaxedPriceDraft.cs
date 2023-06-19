using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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


    }
}
