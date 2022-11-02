using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributesMeta))]
    public partial interface IMissingAttributesMeta
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingAttributesDetails ProductLevel { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingAttributesDetails VariantLevel { get; set; }

        List<string> ProductTypeIds { get; set; }

    }
}
