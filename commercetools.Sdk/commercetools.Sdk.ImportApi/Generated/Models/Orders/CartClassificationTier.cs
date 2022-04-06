using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public partial class CartClassificationTier : ICartClassificationTier
    {
        public IShippingRateTierType Type { get; set; }

        public string Value { get; set; }

        public IMoney Price { get; set; }

        public List<IShippingRatePriceTier> Tiers { get; set; }

        public bool? IsMatching { get; set; }
        public CartClassificationTier()
        {
            this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
