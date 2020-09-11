using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CustomerCreatedMessagePayload : MessagePayload
    {
        public Customer Customer { get; set;}
    }
}
