using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchProjectionParams : IProductSearchProjectionParams
    {
        public IList<string> Expand { get; set; }
        public IEnumerable<string> ExpandEnumerable { set => Expand = value.ToList(); }


        public bool? Staged { get; set; }

        public string PriceCurrency { get; set; }

        public string PriceCountry { get; set; }

        public string PriceCustomerGroup { get; set; }

        public string PriceChannel { get; set; }

        public IList<string> LocaleProjection { get; set; }
        public IEnumerable<string> LocaleProjectionEnumerable { set => LocaleProjection = value.ToList(); }


        public string StoreProjection { get; set; }
    }
}
