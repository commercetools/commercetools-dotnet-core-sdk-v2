using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemDistributionChannelAction))]
    public partial interface ICartSetLineItemDistributionChannelAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }
    }
}
