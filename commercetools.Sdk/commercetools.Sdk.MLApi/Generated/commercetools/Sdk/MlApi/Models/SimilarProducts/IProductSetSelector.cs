using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.ProductSetSelector))]
    public partial interface IProductSetSelector
    {
        string ProjectKey { get; set; }

        IList<string> ProductIds { get; set; }
        IEnumerable<string> ProductIdsEnumerable { set => ProductIds = value.ToList(); }


        IList<string> ProductTypeIds { get; set; }
        IEnumerable<string> ProductTypeIdsEnumerable { set => ProductTypeIds = value.ToList(); }


        bool? Staged { get; set; }

        bool? IncludeVariants { get; set; }

        long? ProductSetLimit { get; set; }

    }
}
