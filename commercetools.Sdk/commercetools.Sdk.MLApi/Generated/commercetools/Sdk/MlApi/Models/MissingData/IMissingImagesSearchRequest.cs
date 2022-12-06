using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesSearchRequest))]
    public partial interface IMissingImagesSearchRequest
    {
        long? Limit { get; set; }

        long? Offset { get; set; }

        bool? Staged { get; set; }

        long? ProductSetLimit { get; set; }

        bool? IncludeVariants { get; set; }

        bool? AutoThreshold { get; set; }

        long? Threshold { get; set; }

        IList<string> ProductIds { get; set; }
        IEnumerable<string> ProductIdsEnumerable { set => ProductIds = value.ToList(); }


        IList<string> ProductTypeIds { get; set; }
        IEnumerable<string> ProductTypeIdsEnumerable { set => ProductTypeIds = value.ToList(); }


    }
}
