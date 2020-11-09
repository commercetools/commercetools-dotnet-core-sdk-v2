using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStateTransitionMessage))]
    public partial interface IOrderStateTransitionMessage : IMessage
    {
        IStateReference State { get; set;}
        
        bool Force { get; set;}
    }
}
