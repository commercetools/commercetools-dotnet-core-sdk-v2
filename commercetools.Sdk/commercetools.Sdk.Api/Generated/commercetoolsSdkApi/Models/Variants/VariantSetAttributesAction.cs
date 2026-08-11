using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAttributesAction : IVariantSetAttributesAction
    {
        public string Action { get; set; }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public bool? Staged { get; set; }
        public VariantSetAttributesAction()
        {
            this.Action = "setAttributes";
        }
    }
}
