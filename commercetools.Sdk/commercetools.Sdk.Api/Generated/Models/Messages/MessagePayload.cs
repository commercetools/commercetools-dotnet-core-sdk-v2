using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public abstract partial class MessagePayload : IMessagePayload
    {
        public string Type { get; set;}
    }
}
