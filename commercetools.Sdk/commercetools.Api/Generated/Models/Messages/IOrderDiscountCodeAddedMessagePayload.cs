using commercetools.Api.Generated.Models.DiscountCodes;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderDiscountCodeAddedMessagePayload : IMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set;}
    }
}
