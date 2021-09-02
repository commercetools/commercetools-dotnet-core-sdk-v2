using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload))]
    public partial interface ICustomerPasswordUpdatedMessagePayload : IMessagePayload
    {
        bool Reset { get; set; }
    }
}
