using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ReviewCreatedMessagePayload : MessagePayload
    {
        public Review Review { get; set;}
    }
}
