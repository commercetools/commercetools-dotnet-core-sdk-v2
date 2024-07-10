using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxRateDraft))]
    public partial interface ITaxRateDraft
    {
        string Name { get; set; }

        decimal? Amount { get; set; }

        bool IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        IList<ISubRate> SubRates { get; set; }
        IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


        string Key { get; set; }

    }
}
