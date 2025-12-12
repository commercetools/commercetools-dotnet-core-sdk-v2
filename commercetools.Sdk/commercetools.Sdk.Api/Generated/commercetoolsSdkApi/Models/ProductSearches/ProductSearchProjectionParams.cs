using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ProductSearchProjectionParams : IProductSearchProjectionParams
    {
        public IList<string> Expand { get; set; }

        public IEnumerable<string> ExpandEnumerable { set => Expand = value.ToList(); }

        public bool? Staged { get; set; }

        public string PriceCurrency { get; set; }

        public string PriceCountry { get; set; }

        public string PriceCustomerGroup { get; set; }

        public IList<string> PriceCustomerGroupAssignments { get; set; }

        public IEnumerable<string> PriceCustomerGroupAssignmentsEnumerable { set => PriceCustomerGroupAssignments = value.ToList(); }

        public string PriceChannel { get; set; }

        public IList<string> LocaleProjection { get; set; }

        public IEnumerable<string> LocaleProjectionEnumerable { set => LocaleProjection = value.ToList(); }

        public string StoreProjection { get; set; }
    }
}
