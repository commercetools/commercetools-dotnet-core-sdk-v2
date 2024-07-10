using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReviewCreatedMessagePayload : IReviewCreatedMessagePayload
    {
        public string Type { get; set; }

        public IReview Review { get; set; }
        public ReviewCreatedMessagePayload()
        {
            this.Type = "ReviewCreated";
        }
    }
}
