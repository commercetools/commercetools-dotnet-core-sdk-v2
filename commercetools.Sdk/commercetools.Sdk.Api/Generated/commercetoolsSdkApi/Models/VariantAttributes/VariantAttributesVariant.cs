using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.VariantAttributes
{

    public partial class VariantAttributesVariant : IVariantAttributesVariant
    {
        public string Id { get; set; }

        public string Sku { get; set; }

        public string Key { get; set; }

        public IVariantAttributesAvailability Availability { get; set; }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
