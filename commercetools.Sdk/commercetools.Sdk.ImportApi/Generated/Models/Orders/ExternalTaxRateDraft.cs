using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ExternalTaxRateDraft : IExternalTaxRateDraft
    {
        public string Name { get; set; }

        public decimal? Amount { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public IList<ISubRate> SubRates { get; set; }
        public IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


        public bool? IncludedInPrice { get; set; }
    }
}
