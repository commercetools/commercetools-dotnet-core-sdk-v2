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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceUpdate))]
    public partial interface IStandalonePriceUpdate
    {
        long Version { get; set; }

        IList<IStandalonePriceUpdateAction> Actions { get; set; }
        IEnumerable<IStandalonePriceUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
