using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setBillingAddress")]
    public partial class OrderSetBillingAddressAction : OrderUpdateAction
    {
        public Address Address { get; set;}
        public OrderSetBillingAddressAction()
        { 
           this.Action = "setBillingAddress";
        }
    }
}
