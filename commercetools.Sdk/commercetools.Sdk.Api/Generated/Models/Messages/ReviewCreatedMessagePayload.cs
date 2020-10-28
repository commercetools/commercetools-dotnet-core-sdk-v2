using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ReviewCreatedMessagePayload : IReviewCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public IReview Review { get; set;}
        public ReviewCreatedMessagePayload()
        { 
           this.Type = "ReviewCreated";
        }
    }
}
