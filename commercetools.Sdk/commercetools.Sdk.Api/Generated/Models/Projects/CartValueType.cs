using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class CartValueType : ICartValueType
    {
        public IShippingRateTierType Type { get; set;}
        public CartValueType()
        { 
           this.Type = IShippingRateTierType.FindEnum("CartValue");
        }
    }
}
