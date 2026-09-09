using System;

namespace commercetools.Sdk.Api.Models.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class FilteredFacetResult : IFilteredFacetResult
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IFacetTypes Type { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }
        public FilteredFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("filter");
        }
    }
}
