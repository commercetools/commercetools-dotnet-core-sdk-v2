using commercetools.Sdk.Api.Models.Projects;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class CartValueType : ICartValueType
    {
        public IShippingRateTierType Type { get; set; }
        public CartValueType()
        {
            this.Type = IShippingRateTierType.FindEnum("CartValue");
        }
    }
}
