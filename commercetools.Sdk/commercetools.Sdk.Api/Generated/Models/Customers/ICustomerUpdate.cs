using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerUpdate))]
    public partial interface ICustomerUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICustomerUpdate, ICustomerUpdateAction>
    {
        new long Version { get; set; }
        new IList<ICustomerUpdateAction> Actions { get; set; }
        IEnumerable<ICustomerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
