using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetStoreAction))]
    public partial interface IStagedOrderSetStoreAction : IStagedOrderUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
