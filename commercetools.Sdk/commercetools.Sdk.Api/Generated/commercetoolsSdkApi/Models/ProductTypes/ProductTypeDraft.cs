using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeDraft : IProductTypeDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<IAttributeDefinitionDraft> Attributes { get; set; }

        public IEnumerable<IAttributeDefinitionDraft> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
