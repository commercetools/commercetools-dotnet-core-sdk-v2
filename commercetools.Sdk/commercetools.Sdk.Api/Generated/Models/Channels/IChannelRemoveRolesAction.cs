using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelRemoveRolesAction))]
    public partial interface IChannelRemoveRolesAction : IChannelUpdateAction
    {
        IList<IChannelRoleEnum> Roles { get; set; }
        IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


    }
}
