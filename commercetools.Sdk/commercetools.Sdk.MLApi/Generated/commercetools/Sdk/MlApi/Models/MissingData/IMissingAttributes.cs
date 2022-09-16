using commercetools.Sdk.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributes))]
    [Obsolete]
    public partial interface IMissingAttributes
    {
        IProductReference Product { get; set; }

        IProductTypeReference ProductType { get; set; }

        int VariantId { get; set; }

        List<string> MissingAttributeValues { get; set; }

        List<string> MissingAttributeNames { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IAttributeCount AttributeCount { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IAttributeCoverage AttributeCoverage { get; set; }

    }
}
