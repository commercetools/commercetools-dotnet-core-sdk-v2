using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction))]
    public partial interface IStagedOrderSetCustomerGroupAction : IStagedOrderUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
    }
}
