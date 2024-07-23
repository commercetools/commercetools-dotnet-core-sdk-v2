using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupUpdate))]
    public partial interface ICustomerGroupUpdate
    {
        long Version { get; set; }

        IList<ICustomerGroupUpdateAction> Actions { get; set; }
        IEnumerable<ICustomerGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
