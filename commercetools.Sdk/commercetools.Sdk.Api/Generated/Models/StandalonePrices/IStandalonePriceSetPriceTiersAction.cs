using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
