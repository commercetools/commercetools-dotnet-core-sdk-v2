using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceUpdate : IStandalonePriceUpdate
    {
        public long Version { get; set; }

        public IList<IStandalonePriceUpdateAction> Actions { get; set; }
        public IEnumerable<IStandalonePriceUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
