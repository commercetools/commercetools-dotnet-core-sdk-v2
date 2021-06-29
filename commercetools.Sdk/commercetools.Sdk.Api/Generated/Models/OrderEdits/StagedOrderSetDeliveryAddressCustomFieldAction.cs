using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryAddressCustomFieldAction : IStagedOrderSetDeliveryAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public StagedOrderSetDeliveryAddressCustomFieldAction()
        { 
           this.Action = "setDeliveryAddressCustomField";
        }
    }
}
