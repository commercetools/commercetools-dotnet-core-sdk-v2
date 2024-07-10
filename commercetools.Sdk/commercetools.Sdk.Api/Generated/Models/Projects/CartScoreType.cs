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

    public partial class CartScoreType : ICartScoreType
    {
        public IShippingRateTierType Type { get; set; }
        public CartScoreType()
        {
            this.Type = IShippingRateTierType.FindEnum("CartScore");
        }
    }
}
