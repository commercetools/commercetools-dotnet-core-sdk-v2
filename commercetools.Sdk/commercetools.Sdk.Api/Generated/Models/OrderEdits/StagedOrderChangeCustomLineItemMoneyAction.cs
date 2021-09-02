using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeCustomLineItemMoneyAction : IStagedOrderChangeCustomLineItemMoneyAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IMoney Money { get; set; }
        public StagedOrderChangeCustomLineItemMoneyAction()
        {
            this.Action = "changeCustomLineItemMoney";
        }
    }
}
