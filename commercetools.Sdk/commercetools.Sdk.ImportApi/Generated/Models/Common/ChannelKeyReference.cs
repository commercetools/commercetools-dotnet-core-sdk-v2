using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class ChannelKeyReference : IChannelKeyReference
    {
        public string Key { get; set; }

        public string TypeId { get; set; }
        public ChannelKeyReference()
        {
            this.TypeId = "channel";
        }
    }
}
