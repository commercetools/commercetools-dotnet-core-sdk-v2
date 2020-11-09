using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStoreSetMessagePayload))]
    public partial interface IOrderStoreSetMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set;}
    }
}
