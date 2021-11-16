using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderEditAppliedMessagePayload : IOrderEditAppliedMessagePayload
    {
        public string Type { get; set;}
        
        public IOrderEditReference Edit { get; set;}
        
        public IOrderEditApplied Result { get; set;}
        public OrderEditAppliedMessagePayload()
        { 
           this.Type = "OrderEditApplied";
        }
    }
}
