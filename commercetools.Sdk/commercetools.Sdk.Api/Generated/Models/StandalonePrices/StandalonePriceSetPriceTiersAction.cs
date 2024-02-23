using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetPriceTiersAction : IStandalonePriceSetPriceTiersAction
    {
        public string Action { get; set; }

        public IList<IPriceTierDraft> Tiers { get; set; }
        public IEnumerable<IPriceTierDraft> TiersEnumerable { set => Tiers = value.ToList(); }

        public StandalonePriceSetPriceTiersAction()
        {
            this.Action = "setPriceTiers";
        }
    }
}
