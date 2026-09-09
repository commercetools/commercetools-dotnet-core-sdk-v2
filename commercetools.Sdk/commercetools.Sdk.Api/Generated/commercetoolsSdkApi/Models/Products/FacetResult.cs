using System;

namespace commercetools.Sdk.Api.Models.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class FacetResult : IFacetResult
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IFacetTypes Type { get; set; }
    }
}
