using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributesSearchRequest))]
    public partial interface IMissingAttributesSearchRequest
    {
        int? Limit { get; set; }

        int? Offset { get; set; }

        bool? Staged { get; set; }

        int? ProductSetLimit { get; set; }

        bool? IncludeVariants { get; set; }

        double? CoverageMin { get; set; }

        double? CoverageMax { get; set; }

        string SortBy { get; set; }

        bool? ShowMissingAttributeNames { get; set; }

        List<string> ProductIds { get; set; }

        List<string> ProductTypeIds { get; set; }

        string AttributeName { get; set; }
    }
}
