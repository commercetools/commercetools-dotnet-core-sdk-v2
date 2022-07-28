using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemSupplyChannelAction))]
    public partial interface IMyCartSetLineItemSupplyChannelAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

    }
}
