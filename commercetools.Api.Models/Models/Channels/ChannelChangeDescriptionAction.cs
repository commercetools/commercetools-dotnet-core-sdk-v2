using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Channels
{
    public class ChannelChangeDescriptionAction : ChannelUpdateAction
    {
        public LocalizedString Description { get; set;}
    }
}
