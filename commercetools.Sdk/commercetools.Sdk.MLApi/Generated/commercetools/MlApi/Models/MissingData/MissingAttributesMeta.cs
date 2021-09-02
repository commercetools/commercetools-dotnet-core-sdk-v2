using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingAttributesMeta : IMissingAttributesMeta
    {
        public IMissingAttributesDetails ProductLevel { get; set; }

        public IMissingAttributesDetails VariantLevel { get; set; }

        public List<string> ProductTypeIds { get; set; }
    }
}
