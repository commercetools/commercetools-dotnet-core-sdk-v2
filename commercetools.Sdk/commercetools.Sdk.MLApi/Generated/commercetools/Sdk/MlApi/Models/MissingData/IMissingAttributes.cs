using commercetools.Sdk.MLApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributes))]
    public partial interface IMissingAttributes
    {
        IProductReference Product { get; set; }

        IProductTypeReference ProductType { get; set; }

        int VariantId { get; set; }

        List<string> MissingAttributeValues { get; set; }

        List<string> MissingAttributeNames { get; set; }

        IAttributeCount AttributeCount { get; set; }

        IAttributeCoverage AttributeCoverage { get; set; }

    }
}
