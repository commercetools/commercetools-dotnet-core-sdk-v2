using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderCustomerEmailSetMessage : Message
    {
        public string Email { get; set;}
        
        public string OldEmail { get; set;}
    }
}
