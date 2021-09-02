using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    public partial interface IOrderEditAppliedMessagePayload : IMessagePayload
    {
        IOrderEditReference Edit { get; set; }

        IOrderEditApplied Result { get; set; }
    }
}
