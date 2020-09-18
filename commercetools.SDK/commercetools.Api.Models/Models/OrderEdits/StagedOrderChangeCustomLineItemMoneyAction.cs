using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeCustomLineItemMoney")]
    public class StagedOrderChangeCustomLineItemMoneyAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public Money Money { get; set;}
    }
}
