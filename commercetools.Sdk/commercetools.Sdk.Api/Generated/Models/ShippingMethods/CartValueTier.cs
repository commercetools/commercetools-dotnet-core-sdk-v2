using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class CartValueTier : ICartValueTier
    {
        public IShippingRateTierType Type { get; set; }

        public long MinimumCentAmount { get; set; }

        public IMoney Price { get; set; }

        public bool? IsMatching { get; set; }
        public CartValueTier()
        {
            this.Type = IShippingRateTierType.FindEnum("CartValue");
        }
    }
}
