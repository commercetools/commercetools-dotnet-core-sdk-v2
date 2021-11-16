using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction))]
    public partial interface IStagedOrderSetLineItemDistributionChannelAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
