using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerUpdate))]
    public partial interface ICustomerUpdate
    {
        long Version { get; set; }

        IList<ICustomerUpdateAction> Actions { get; set; }

        IEnumerable<ICustomerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
