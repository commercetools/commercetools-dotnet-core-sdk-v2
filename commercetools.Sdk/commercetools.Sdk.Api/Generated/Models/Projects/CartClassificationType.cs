using commercetools.Sdk.Api.Models.Projects;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
