using commercetools.Sdk.MLApi.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingAttributes : IMissingAttributes
    {
        public IProductReference Product { get; set; }

        public IProductTypeReference ProductType { get; set; }

        public int VariantId { get; set; }

        public List<string> MissingAttributeValues { get; set; }

        public List<string> MissingAttributeNames { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IAttributeCount AttributeCount { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IAttributeCoverage AttributeCoverage { get; set; }
    }
}
