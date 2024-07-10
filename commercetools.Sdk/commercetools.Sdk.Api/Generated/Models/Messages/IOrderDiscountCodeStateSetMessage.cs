using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessage))]
    public partial interface IOrderDiscountCodeStateSetMessage : IOrderMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }

        IDiscountCodeState OldState { get; set; }

    }
}
