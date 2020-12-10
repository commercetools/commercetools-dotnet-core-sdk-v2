using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeStateSetMessage))]
    public partial interface IOrderDiscountCodeStateSetMessage : IMessage
    {
        IDiscountCodeReference DiscountCode { get; set;}
        
        IDiscountCodeState State { get; set;}
        
        IDiscountCodeState OldState { get; set;}
    }
}
