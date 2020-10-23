using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.DiscountCodes;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderDiscountCodeStateSetMessagePayload : IMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set;}
        
        string State { get; set;}
        
        DiscountCodeState StateAsEnum { get; }
        
        string OldState { get; set;}
        
        DiscountCodeState OldStateAsEnum { get; }
    }
}
