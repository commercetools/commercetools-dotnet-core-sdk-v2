using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerEmailChanged")]
    public class CustomerEmailChangedMessagePayload : MessagePayload
    {
        public string Email { get; set;}
    }
}
