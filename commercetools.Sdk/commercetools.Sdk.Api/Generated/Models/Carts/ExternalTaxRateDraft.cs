using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ExternalTaxRateDraft : IExternalTaxRateDraft
    {
        public string Name { get; set; }

        public decimal? Amount { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public List<ISubRate> SubRates { get; set; }

        public bool? IncludedInPrice { get; set; }
    }
}
