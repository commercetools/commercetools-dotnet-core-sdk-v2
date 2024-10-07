using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetStoreAction))]
    public partial interface IOrderSetStoreAction : IOrderUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
