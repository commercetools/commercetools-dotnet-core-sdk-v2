using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeRemoved")]
    public partial class OrderDiscountCodeRemovedMessagePayload : MessagePayload
    {
        public DiscountCodeReference DiscountCode { get; set;}
        public OrderDiscountCodeRemovedMessagePayload()
        { 
           this.Type = "OrderDiscountCodeRemoved";
        }
    }
}
