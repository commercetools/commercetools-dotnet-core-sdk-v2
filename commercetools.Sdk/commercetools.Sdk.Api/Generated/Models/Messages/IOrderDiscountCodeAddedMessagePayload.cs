using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload))]
    public partial interface IOrderDiscountCodeAddedMessagePayload : IMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set;}
    }
}
