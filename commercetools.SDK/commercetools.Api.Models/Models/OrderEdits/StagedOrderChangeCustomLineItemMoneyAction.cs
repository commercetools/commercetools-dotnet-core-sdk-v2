using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeCustomLineItemMoney")]
    public partial class StagedOrderChangeCustomLineItemMoneyAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public Money Money { get; set;}
        public StagedOrderChangeCustomLineItemMoneyAction()
        { 
           this.Action = "changeCustomLineItemMoney";
        }
    }
}
