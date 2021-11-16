using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetLineItemDistributionChannelAction))]
    public partial interface IMyCartSetLineItemDistributionChannelAction : IMyCartUpdateAction
    {
        string LineItemId { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
