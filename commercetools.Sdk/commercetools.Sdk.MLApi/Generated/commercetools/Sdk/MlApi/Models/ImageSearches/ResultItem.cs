using commercetools.Sdk.MLApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{

    public partial class ResultItem : IResultItem
    {
        public string ImageUrl { get; set; }

        public List<IProductVariant> ProductVariants { get; set; }
    }
}
