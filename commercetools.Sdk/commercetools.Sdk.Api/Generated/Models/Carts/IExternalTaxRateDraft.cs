using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ExternalTaxRateDraft))]
    public partial interface IExternalTaxRateDraft
    {
        string Name { get; set; }

        decimal? Amount { get; set; }

        bool? IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        IList<ISubRate> SubRates { get; set; }
        IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


    }
}
