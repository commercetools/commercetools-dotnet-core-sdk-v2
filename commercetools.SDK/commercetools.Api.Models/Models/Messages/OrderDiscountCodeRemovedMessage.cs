using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeRemoved")]
    public class OrderDiscountCodeRemovedMessage : Message
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
