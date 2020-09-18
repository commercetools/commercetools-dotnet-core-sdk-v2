using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerEmailSet")]
    public class OrderCustomerEmailSetMessagePayload : MessagePayload
    {
        public string Email { get; set;}
        
        public string OldEmail { get; set;}
    }
}
