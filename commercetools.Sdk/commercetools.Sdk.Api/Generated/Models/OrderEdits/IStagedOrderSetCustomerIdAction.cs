using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction))]
    public partial interface IStagedOrderSetCustomerIdAction : IStagedOrderUpdateAction
    {
        string CustomerId { get; set; }

    }
}
