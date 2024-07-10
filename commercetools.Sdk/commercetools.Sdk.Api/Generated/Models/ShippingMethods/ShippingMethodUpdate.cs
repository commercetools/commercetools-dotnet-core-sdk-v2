using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodUpdate : IShippingMethodUpdate
    {
        public long Version { get; set; }

        public IList<IShippingMethodUpdateAction> Actions { get; set; }
        public IEnumerable<IShippingMethodUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
