using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.VariantAttributes
{

    public partial class VariantAttributes : IVariantAttributes
    {
        public string ProductId { get; set; }

        public string ProductKey { get; set; }

        public IList<IVariantAttributesAttributeMetadata> Attributes { get; set; }

        public IEnumerable<IVariantAttributesAttributeMetadata> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IList<IVariantAttributesVariant> Variants { get; set; }

        public IEnumerable<IVariantAttributesVariant> VariantsEnumerable { set => Variants = value.ToList(); }
    }
}
