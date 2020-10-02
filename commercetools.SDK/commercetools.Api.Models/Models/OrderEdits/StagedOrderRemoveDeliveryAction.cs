using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeDelivery")]
    public partial class StagedOrderRemoveDeliveryAction : StagedOrderUpdateAction
    {
        public string DeliveryId { get; set;}
        public StagedOrderRemoveDeliveryAction()
        { 
           this.Action = "removeDelivery";
        }
    }
}
