using System;
using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{

    public partial class MissingPricesSearchRequest : IMissingPricesSearchRequest
    {
        public long? Limit { get; set; }

        public long? Offset { get; set; }

        public bool? Staged { get; set; }

        public long? ProductSetLimit { get; set; }

        public bool? IncludeVariants { get; set; }

        public string CurrencyCode { get; set; }

        public bool? CheckDate { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public List<string> ProductIds { get; set; }

        public List<string> ProductTypeIds { get; set; }
    }
}
