using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction))]
    public partial interface IStagedOrderSetCustomerGroupAction : IStagedOrderUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

    }
}
