using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Projects
{
    public partial class CartClassificationType : ICartClassificationType
    {
        public IShippingRateTierType Type { get; set;}
        
        public List<ICustomFieldLocalizedEnumValue> Values { get; set;}
        public CartClassificationType()
        { 
           this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
