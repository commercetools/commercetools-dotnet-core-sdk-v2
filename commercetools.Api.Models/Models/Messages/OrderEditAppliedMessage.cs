using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderEditAppliedMessage : Message
    {
        public OrderEditReference Edit { get; set;}
        
        public OrderEditApplied Result { get; set;}
    }
}
