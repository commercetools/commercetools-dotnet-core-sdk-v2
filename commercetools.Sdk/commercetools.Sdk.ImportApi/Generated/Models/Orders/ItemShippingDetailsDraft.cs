using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ItemShippingDetailsDraft : IItemShippingDetailsDraft
    {
        public IList<IItemShippingTarget> Targets { get; set; }
        public IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }

    }
}
