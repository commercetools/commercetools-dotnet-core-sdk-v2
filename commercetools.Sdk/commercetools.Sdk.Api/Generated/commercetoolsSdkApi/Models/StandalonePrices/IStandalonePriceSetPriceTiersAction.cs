using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetPriceTiersAction))]
    public partial interface IStandalonePriceSetPriceTiersAction : IStandalonePriceUpdateAction
    {
        IList<IPriceTierDraft> Tiers { get; set; }
        IEnumerable<IPriceTierDraft> TiersEnumerable { set => Tiers = value.ToList(); }


    }
}
