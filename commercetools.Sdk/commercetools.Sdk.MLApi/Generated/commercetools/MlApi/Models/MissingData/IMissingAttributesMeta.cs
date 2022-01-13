using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingAttributesMeta))]
    public partial interface IMissingAttributesMeta
    {
        IMissingAttributesDetails ProductLevel { get; set; }

        IMissingAttributesDetails VariantLevel { get; set; }

        List<string> ProductTypeIds { get; set; }
    }
}
