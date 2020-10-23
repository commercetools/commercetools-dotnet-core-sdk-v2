using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderEditAppliedMessagePayload : IMessagePayload
    {
        IOrderEditReference Edit { get; set;}
        
        IOrderEditApplied Result { get; set;}
    }
}
