using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TaxedItemPrice))]
    public partial interface ITaxedItemPrice
    {
        ICentPrecisionMoney TotalNet { get; set; }

        ICentPrecisionMoney TotalGross { get; set; }

        IList<ITaxPortion> TaxPortions { get; set; }

        IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }

        ICentPrecisionMoney TotalTax { get; set; }

    }
}
