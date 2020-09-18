using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeAdded")]
    public class OrderDiscountCodeAddedMessage : Message
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
