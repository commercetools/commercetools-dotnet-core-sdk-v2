using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingAttributesMeta : IMissingAttributesMeta
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingAttributesDetails ProductLevel { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingAttributesDetails VariantLevel { get; set; }

        public IList<string> ProductTypeIds { get; set; }
        public IEnumerable<string> ProductTypeIdsEnumerable { set => ProductTypeIds = value.ToList(); }

    }
}
