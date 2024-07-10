using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelUpdate : IChannelUpdate
    {
        public long Version { get; set; }

        public IList<IChannelUpdateAction> Actions { get; set; }
        public IEnumerable<IChannelUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
