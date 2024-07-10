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

    public partial class ChannelChangeNameAction : IChannelChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ChannelChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
