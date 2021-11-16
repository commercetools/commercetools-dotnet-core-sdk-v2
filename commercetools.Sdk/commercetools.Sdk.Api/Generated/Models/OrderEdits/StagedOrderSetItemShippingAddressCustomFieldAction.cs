using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetItemShippingAddressCustomFieldAction : IStagedOrderSetItemShippingAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string AddressKey { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public StagedOrderSetItemShippingAddressCustomFieldAction()
        { 
           this.Action = "setItemShippingAddressCustomField";
        }
    }
}
