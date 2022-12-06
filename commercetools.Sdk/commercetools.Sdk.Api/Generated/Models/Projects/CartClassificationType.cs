using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class CartClassificationType : ICartClassificationType
    {
        public IShippingRateTierType Type { get; set; }

        public IList<ICustomFieldLocalizedEnumValue> Values { get; set; }
        public IEnumerable<ICustomFieldLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public CartClassificationType()
        {
            this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
