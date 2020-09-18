using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeStateSet")]
    public class OrderDiscountCodeStateSetMessage : Message
    {
        public DiscountCodeReference DiscountCode { get; set;}
        
        public string State { get; set;}
        
        public DiscountCodeState StateAsEnum => this.State.GetEnum<DiscountCodeState>();
        
        public string OldState { get; set;}
        
        public DiscountCodeState OldStateAsEnum => this.OldState.GetEnum<DiscountCodeState>();
    }
}
