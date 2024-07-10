using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceTiersSetMessagePayload))]
    public partial interface IStandalonePriceTiersSetMessagePayload : IMessagePayload
    {
        IList<IPriceTier> Tiers { get; set; }
        IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        IList<IPriceTier> PreviousTiers { get; set; }
        IEnumerable<IPriceTier> PreviousTiersEnumerable { set => PreviousTiers = value.ToList(); }


    }
}
