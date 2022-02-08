using System.Collections.Generic;


namespace commercetools.Api.Models.Products
{
    public partial class RangeFacetResult : IRangeFacetResult
    {
        public IFacetTypes Type { get; set; }

        public List<IFacetRange> Ranges { get; set; }
        public RangeFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("range");
        }
    }
}
