using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelReference : IChannelReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IChannel Obj { get; set; }
        public ChannelReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("channel");
        }
    }
}
