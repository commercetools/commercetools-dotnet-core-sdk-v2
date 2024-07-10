using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessagePayload))]
    public partial interface IReviewCreatedMessagePayload : IMessagePayload
    {
        IReview Review { get; set; }

    }
}
