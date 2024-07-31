using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerEmailAction))]
    public partial interface IStagedOrderSetCustomerEmailAction : IStagedOrderUpdateAction
    {
        string Email { get; set; }

    }
}
