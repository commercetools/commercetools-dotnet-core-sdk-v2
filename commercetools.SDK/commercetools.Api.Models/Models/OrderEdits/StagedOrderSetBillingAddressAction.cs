using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setBillingAddress")]
    public partial class StagedOrderSetBillingAddressAction : StagedOrderUpdateAction
    {
        public Address Address { get; set;}
        public StagedOrderSetBillingAddressAction()
        { 
           this.Action = "setBillingAddress";
        }
    }
}
