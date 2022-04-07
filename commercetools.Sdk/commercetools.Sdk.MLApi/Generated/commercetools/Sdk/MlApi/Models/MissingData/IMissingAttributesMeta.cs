using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributesMeta))]
    public partial interface IMissingAttributesMeta
    {
        IMissingAttributesDetails ProductLevel { get; set; }

        IMissingAttributesDetails VariantLevel { get; set; }

        List<string> ProductTypeIds { get; set; }
    }
}
