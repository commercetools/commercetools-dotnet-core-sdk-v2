using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelUpdate))]
    public partial interface IChannelUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IChannelUpdate, IChannelUpdateAction>
    {
        new long Version { get; set; }
        new IList<IChannelUpdateAction> Actions { get; set; }
        IEnumerable<IChannelUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
