using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderUpdate : IOrderUpdate
    {
        public long Version { get; set; }

        public List<IOrderUpdateAction> Actions { get; set; }
    }
}
