using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction))]
    public partial interface IStagedOrderSetOrderNumberAction : IStagedOrderUpdateAction
    {
        string OrderNumber { get; set; }
    }
}
