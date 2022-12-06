using commercetools.Sdk.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributes))]
    public partial interface IMissingAttributes
    {
        IProductReference Product { get; set; }

        IProductTypeReference ProductType { get; set; }

        int VariantId { get; set; }

        IList<string> MissingAttributeValues { get; set; }
        IEnumerable<string> MissingAttributeValuesEnumerable { set => MissingAttributeValues = value.ToList(); }


        IList<string> MissingAttributeNames { get; set; }
        IEnumerable<string> MissingAttributeNamesEnumerable { set => MissingAttributeNames = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        IAttributeCount AttributeCount { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IAttributeCoverage AttributeCoverage { get; set; }

    }
}
