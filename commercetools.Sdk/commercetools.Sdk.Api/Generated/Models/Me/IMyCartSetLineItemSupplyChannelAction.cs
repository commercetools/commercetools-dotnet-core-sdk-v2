using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetLineItemSupplyChannelAction))]
    public partial interface IMyCartSetLineItemSupplyChannelAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }
    }
}
