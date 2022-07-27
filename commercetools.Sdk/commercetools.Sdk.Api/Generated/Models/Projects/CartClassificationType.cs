using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class CartClassificationType : ICartClassificationType
    {
        public IShippingRateTierType Type { get; set; }

        public List<ICustomFieldLocalizedEnumValue> Values { get; set; }
        public CartClassificationType()
        {
            this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
