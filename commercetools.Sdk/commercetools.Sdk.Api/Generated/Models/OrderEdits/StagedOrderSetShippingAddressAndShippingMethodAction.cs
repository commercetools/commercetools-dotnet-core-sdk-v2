using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingAddressAndShippingMethodAction : IStagedOrderSetShippingAddressAndShippingMethodAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        
        public IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetShippingAddressAndShippingMethodAction()
        { 
           this.Action = "setShippingAddressAndShippingMethod";
        }
    }
}
