using System.Collections.Generic;
using System.Linq;
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

        decimal? CoverageMin { get; set; }

        decimal? CoverageMax { get; set; }

        string SortBy { get; set; }

        bool? ShowMissingAttributeNames { get; set; }

        IList<string> ProductIds { get; set; }
        IEnumerable<string> ProductIdsEnumerable { set => ProductIds = value.ToList(); }


        IList<string> ProductTypeIds { get; set; }
        IEnumerable<string> ProductTypeIdsEnumerable { set => ProductTypeIds = value.ToList(); }


        string AttributeName { get; set; }

    }
}
