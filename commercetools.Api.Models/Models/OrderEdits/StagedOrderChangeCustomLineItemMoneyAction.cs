using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderChangeCustomLineItemMoneyAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public Money Money { get; set;}
    }
}
