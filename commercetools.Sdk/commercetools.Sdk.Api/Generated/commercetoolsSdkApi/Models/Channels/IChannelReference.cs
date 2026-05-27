using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelReference))]
    public partial interface IChannelReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IChannel Obj { get; set; }

        new string Id { get; set; }

    }
}
