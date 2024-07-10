using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelDraft))]
    public partial interface IChannelDraft
    {
        string Key { get; set; }

        IList<IChannelRoleEnum> Roles { get; set; }
        IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IBaseAddress Address { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IGeoJson GeoLocation { get; set; }

    }
}
