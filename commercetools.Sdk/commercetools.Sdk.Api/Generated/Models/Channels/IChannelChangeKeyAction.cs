using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelChangeKeyAction))]
    public partial interface IChannelChangeKeyAction : IChannelUpdateAction
    {
        string Key { get; set; }

    }
}
