using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryAddressAction : IStagedOrderSetDeliveryAddressAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public IAddress Address { get; set;}
        public StagedOrderSetDeliveryAddressAction()
        { 
           this.Action = "setDeliveryAddress";
        }
    }
}
