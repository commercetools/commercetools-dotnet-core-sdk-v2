using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ChannelReference))]
    public partial interface IChannelReference : IReference
    {
        new string Id { get; set; }

    }
}
