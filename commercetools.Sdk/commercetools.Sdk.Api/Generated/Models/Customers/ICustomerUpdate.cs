using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerUpdate))]
    public partial interface ICustomerUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICustomerUpdate, ICustomerUpdateAction>
    {
        new long Version { get; set; }
        new List<ICustomerUpdateAction> Actions { get; set; }
    }
}
