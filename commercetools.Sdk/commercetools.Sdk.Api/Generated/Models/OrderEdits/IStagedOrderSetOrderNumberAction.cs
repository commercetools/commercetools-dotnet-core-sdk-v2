using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction))]
    public partial interface IStagedOrderSetOrderNumberAction : IStagedOrderUpdateAction
    {
        string OrderNumber { get; set; }
    }
}
