using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TaxRate : ITaxRate
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public bool IncludedInPrice { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public IList<ISubRate> SubRates { get; set; }
        public IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }

    }
}
