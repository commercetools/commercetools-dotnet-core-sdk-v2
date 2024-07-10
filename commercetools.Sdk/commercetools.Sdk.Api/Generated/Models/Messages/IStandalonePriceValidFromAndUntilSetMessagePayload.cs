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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessagePayload))]
    public partial interface IStandalonePriceValidFromAndUntilSetMessagePayload : IMessagePayload
    {
        DateTime? ValidFrom { get; set; }

        DateTime? PreviousValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? PreviousValidUntil { get; set; }

    }
}
