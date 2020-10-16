using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("updateItemShippingAddress")]
    public partial class StagedOrderUpdateItemShippingAddressAction : StagedOrderUpdateAction
    {
        public Address Address { get; set;}
        public StagedOrderUpdateItemShippingAddressAction()
        { 
           this.Action = "updateItemShippingAddress";
        }
    }
}
