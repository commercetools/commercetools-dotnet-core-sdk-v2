using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ReviewCreated")]
    public partial class ReviewCreatedMessagePayload : MessagePayload
    {
        public Review Review { get; set;}
        public ReviewCreatedMessagePayload()
        { 
           this.Type = "ReviewCreated";
        }
    }
}
