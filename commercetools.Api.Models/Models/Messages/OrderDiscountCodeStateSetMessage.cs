using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderDiscountCodeStateSetMessage : Message
    {
        public DiscountCodeReference DiscountCode { get; set;}
        
        public DiscountCodeState State { get; set;}
        
        public DiscountCodeState OldState { get; set;}
    }
}
