using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeAdded")]
    public class OrderDiscountCodeAddedMessagePayload : MessagePayload
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
