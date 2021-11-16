using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction))]
    public partial interface IStagedOrderChangeOrderStateAction : IStagedOrderUpdateAction
    {
        IOrderState OrderState { get; set;}
    }
}
