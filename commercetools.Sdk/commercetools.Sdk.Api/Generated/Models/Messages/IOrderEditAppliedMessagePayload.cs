using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    public partial interface IOrderEditAppliedMessagePayload : IOrderMessagePayload
    {
        IOrderEdit Edit { get; set; }

        IOrderEditApplied Result { get; set; }

    }
}
