using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeRemoved")]
    public class OrderDiscountCodeRemovedMessagePayload : MessagePayload
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
