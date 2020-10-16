using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeAdded")]
    public partial class OrderDiscountCodeAddedMessage : Message
    {
        public DiscountCodeReference DiscountCode { get; set;}
        public OrderDiscountCodeAddedMessage()
        { 
           this.Type = "OrderDiscountCodeAdded";
        }
    }
}
