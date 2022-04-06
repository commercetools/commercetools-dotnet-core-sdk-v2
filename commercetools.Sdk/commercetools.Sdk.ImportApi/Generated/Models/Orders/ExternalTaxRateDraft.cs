using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public partial class ExternalTaxRateDraft : IExternalTaxRateDraft
    {
        public string Name { get; set; }

        public double? Amount { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public List<ISubRate> SubRates { get; set; }

        public bool? IncludedInPrice { get; set; }
    }
}
