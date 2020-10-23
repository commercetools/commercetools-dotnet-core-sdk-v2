using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Channels
{
    public interface IChannelReference : IReference
    {
        IChannel Obj { get; set;}
    }
}
