using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeParcelFromDelivery")]
    public partial class StagedOrderRemoveParcelFromDeliveryAction : StagedOrderUpdateAction
    {
        public string ParcelId { get; set;}
        public StagedOrderRemoveParcelFromDeliveryAction()
        { 
           this.Action = "removeParcelFromDelivery";
        }
    }
}
