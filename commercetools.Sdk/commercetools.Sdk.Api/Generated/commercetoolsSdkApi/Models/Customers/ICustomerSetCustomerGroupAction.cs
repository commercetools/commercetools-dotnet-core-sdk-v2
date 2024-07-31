using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerGroupAction))]
    public partial interface ICustomerSetCustomerGroupAction : ICustomerUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

    }
}
