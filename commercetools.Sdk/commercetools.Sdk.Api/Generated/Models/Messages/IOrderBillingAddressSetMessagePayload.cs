using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderBillingAddressSetMessagePayload))]
    public partial interface IOrderBillingAddressSetMessagePayload : IOrderMessagePayload
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }

    }
}
