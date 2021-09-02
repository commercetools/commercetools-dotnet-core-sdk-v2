using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelDraft))]
    public partial interface IChannelDraft
    {
        string Key { get; set; }

        List<IChannelRoleEnum> Roles { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IBaseAddress Address { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IGeoJson GeoLocation { get; set; }
    }
}
