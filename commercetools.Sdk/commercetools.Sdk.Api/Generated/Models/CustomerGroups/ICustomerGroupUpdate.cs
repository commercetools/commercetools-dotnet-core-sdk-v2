using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupUpdate))]
    public partial interface ICustomerGroupUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICustomerGroupUpdate, ICustomerGroupUpdateAction>
    {
        new long Version { get; set; }
        new List<ICustomerGroupUpdateAction> Actions { get; set; }
    }
}
