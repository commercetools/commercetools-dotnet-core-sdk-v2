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
    public partial class ReviewCreatedMessage : Message
    {
        public Review Review { get; set;}
        public ReviewCreatedMessage()
        { 
           this.Type = "ReviewCreated";
        }
    }
}
