using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderUpdate : IOrderUpdate
    {
        public long Version { get; set; }

        public IList<IOrderUpdateAction> Actions { get; set; }
        public IEnumerable<IOrderUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
