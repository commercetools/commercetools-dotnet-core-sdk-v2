using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessagePayload))]
    public partial interface IStandalonePriceCreatedMessagePayload : IMessagePayload
    {
        IStandalonePrice StandalonePrice { get; set; }

    }
}
