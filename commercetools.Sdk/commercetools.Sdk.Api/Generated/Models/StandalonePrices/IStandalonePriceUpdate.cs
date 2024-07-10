using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceUpdate))]
    public partial interface IStandalonePriceUpdate
    {
        long Version { get; set; }

        IList<IStandalonePriceUpdateAction> Actions { get; set; }
        IEnumerable<IStandalonePriceUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
