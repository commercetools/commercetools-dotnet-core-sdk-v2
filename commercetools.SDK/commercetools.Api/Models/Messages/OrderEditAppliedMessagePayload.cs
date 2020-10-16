using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderEditApplied")]
    public partial class OrderEditAppliedMessagePayload : MessagePayload
    {
        public OrderEditReference Edit { get; set;}
        
        public OrderEditApplied Result { get; set;}
        public OrderEditAppliedMessagePayload()
        { 
           this.Type = "OrderEditApplied";
        }
    }
}
