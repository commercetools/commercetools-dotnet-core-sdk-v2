using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxRateDraft))]
    public partial interface ITaxRateDraft
    {
        string Name { get; set; }

        double? Amount { get; set; }

        bool IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        List<ISubRate> SubRates { get; set; }
    }
}
