using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction))]
    public partial interface IStagedOrderSetLineItemDistributionChannelAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

    }
}
