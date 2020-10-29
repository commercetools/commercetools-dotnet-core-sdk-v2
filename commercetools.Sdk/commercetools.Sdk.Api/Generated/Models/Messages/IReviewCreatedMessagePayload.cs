using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ReviewCreatedMessagePayload))]
    public interface IReviewCreatedMessagePayload : IMessagePayload
    {
        IReview Review { get; set;}
    }
}
