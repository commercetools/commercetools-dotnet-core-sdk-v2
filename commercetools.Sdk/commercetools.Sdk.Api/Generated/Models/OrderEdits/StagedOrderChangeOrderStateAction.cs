using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeOrderStateAction : IStagedOrderChangeOrderStateAction
    {
        public string Action { get; set; }

        public IOrderState OrderState { get; set; }
        public StagedOrderChangeOrderStateAction()
        {
            this.Action = "changeOrderState";
        }
    }
}
