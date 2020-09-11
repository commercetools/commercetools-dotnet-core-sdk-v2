using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderDiscountCodeAddedMessagePayload : MessagePayload
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
