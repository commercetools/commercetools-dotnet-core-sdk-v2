using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxRateDraft : ITaxRateDraft
    {
        public string Name { get; set; }

        public decimal? Amount { get; set; }

        public bool IncludedInPrice { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public IList<ISubRate> SubRates { get; set; }
        public IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


        public string Key { get; set; }
    }
}
