using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnInfoAction : IOrderSetReturnInfoAction
    {
        public string Action { get; set; }

        public IList<IReturnInfoDraft> Items { get; set; }
        public IEnumerable<IReturnInfoDraft> ItemsEnumerable { set => Items = value.ToList(); }

        public OrderSetReturnInfoAction()
        {
            this.Action = "setReturnInfo";
        }
    }
}
