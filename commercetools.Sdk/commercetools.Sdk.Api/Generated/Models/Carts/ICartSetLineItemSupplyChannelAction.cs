using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemSupplyChannelAction))]
    public partial interface ICartSetLineItemSupplyChannelAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

    }
}
