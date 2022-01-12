using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetLineItemSupplyChannelAction))]
    public partial interface ICartSetLineItemSupplyChannelAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }
    }
}
