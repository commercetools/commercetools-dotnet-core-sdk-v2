using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditAddStagedActionAction))]
    public partial interface IOrderEditAddStagedActionAction : IOrderEditUpdateAction
    {
        IStagedOrderUpdateAction StagedAction { get; set; }

    }
}
