using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxRateDraft : ITaxRateDraft
    {
        public string Name { get; set; }

        public double? Amount { get; set; }

        public bool IncludedInPrice { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public List<ISubRate> SubRates { get; set; }
    }
}
