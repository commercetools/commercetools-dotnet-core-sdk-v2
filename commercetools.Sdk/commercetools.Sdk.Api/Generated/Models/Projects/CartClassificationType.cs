using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
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
