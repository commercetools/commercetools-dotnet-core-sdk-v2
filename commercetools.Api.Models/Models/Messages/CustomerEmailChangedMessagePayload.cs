using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CustomerEmailChangedMessagePayload : MessagePayload
    {
        public string Email { get; set;}
    }
}
