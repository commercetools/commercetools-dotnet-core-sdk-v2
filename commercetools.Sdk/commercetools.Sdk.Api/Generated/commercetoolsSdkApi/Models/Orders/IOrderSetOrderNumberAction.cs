using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetOrderNumberAction))]
    public partial interface IOrderSetOrderNumberAction : IOrderUpdateAction
    {
        string OrderNumber { get; set; }

    }
}
