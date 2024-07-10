using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceTiersSetMessagePayload : IStandalonePriceTiersSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IPriceTier> Tiers { get; set; }
        public IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        public IList<IPriceTier> PreviousTiers { get; set; }
        public IEnumerable<IPriceTier> PreviousTiersEnumerable { set => PreviousTiers = value.ToList(); }

        public StandalonePriceTiersSetMessagePayload()
        {
            this.Type = "StandalonePriceTiersSet";
        }
    }
}
