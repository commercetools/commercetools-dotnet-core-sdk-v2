using commercetools.MLApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.MLApi.Models.ImageSearches
{
    public partial class ResultItem : IResultItem
    {
        public string ImageUrl { get; set; }

        public List<IProductVariant> ProductVariants { get; set; }
    }
}
