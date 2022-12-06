using commercetools.Sdk.MLApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{

    public partial class ResultItem : IResultItem
    {
        public string ImageUrl { get; set; }

        public IList<IProductVariant> ProductVariants { get; set; }
        public IEnumerable<IProductVariant> ProductVariantsEnumerable { set => ProductVariants = value.ToList(); }

    }
}
