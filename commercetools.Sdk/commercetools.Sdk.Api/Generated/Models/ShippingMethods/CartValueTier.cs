using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
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
