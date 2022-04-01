using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupUpdate))]
    public partial interface ICustomerGroupUpdate
    {
        long Version { get; set; }

        List<ICustomerGroupUpdateAction> Actions { get; set; }
    }
}
