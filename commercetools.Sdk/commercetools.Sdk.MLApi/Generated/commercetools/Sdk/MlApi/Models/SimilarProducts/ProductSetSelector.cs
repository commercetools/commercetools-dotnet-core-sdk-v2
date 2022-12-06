using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class ProductSetSelector : IProductSetSelector
    {
        public string ProjectKey { get; set; }

        public IList<string> ProductIds { get; set; }
        public IEnumerable<string> ProductIdsEnumerable { set => ProductIds = value.ToList(); }


        public IList<string> ProductTypeIds { get; set; }
        public IEnumerable<string> ProductTypeIdsEnumerable { set => ProductTypeIds = value.ToList(); }


        public bool? Staged { get; set; }

        public bool? IncludeVariants { get; set; }

        public long? ProductSetLimit { get; set; }
    }
}
