using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    public partial class ProductSetSelector : IProductSetSelector
    {
        public string ProjectKey { get; set; }

        public List<string> ProductIds { get; set; }

        public List<string> ProductTypeIds { get; set; }

        public bool? Staged { get; set; }

        public bool? IncludeVariants { get; set; }

        public long? ProductSetLimit { get; set; }
    }
}
