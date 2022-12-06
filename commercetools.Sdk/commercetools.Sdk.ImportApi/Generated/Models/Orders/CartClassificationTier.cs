using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class CartClassificationTier : ICartClassificationTier
    {
        public IShippingRateTierType Type { get; set; }

        public string Value { get; set; }

        public IMoney Price { get; set; }

        public IList<IShippingRatePriceTier> Tiers { get; set; }
        public IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        public bool? IsMatching { get; set; }
        public CartClassificationTier()
        {
            this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
