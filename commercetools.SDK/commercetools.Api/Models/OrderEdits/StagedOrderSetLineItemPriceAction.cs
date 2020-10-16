using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemPrice")]
    public partial class StagedOrderSetLineItemPriceAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public Money ExternalPrice { get; set;}
        public StagedOrderSetLineItemPriceAction()
        { 
           this.Action = "setLineItemPrice";
        }
    }
}
