using System.Collections.Generic;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingAttributesMeta : IMissingAttributesMeta
    {
        public IMissingAttributesDetails ProductLevel { get; set; }

        public IMissingAttributesDetails VariantLevel { get; set; }

        public List<string> ProductTypeIds { get; set; }
    }
}
