using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction))]
    public partial interface IStagedOrderChangeOrderStateAction : IStagedOrderUpdateAction
    {
        IOrderState OrderState { get; set; }
    }
}
