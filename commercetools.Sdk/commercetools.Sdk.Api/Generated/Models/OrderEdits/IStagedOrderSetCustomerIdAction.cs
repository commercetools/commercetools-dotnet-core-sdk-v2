using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction))]
    public partial interface IStagedOrderSetCustomerIdAction : IStagedOrderUpdateAction
    {
        string CustomerId { get; set;}
    }
}
