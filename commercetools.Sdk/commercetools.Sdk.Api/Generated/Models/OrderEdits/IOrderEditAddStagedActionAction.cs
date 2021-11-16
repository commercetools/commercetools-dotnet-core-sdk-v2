using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditAddStagedActionAction))]
    public partial interface IOrderEditAddStagedActionAction : IOrderEditUpdateAction
    {
        IStagedOrderUpdateAction StagedAction { get; set;}
    }
}
