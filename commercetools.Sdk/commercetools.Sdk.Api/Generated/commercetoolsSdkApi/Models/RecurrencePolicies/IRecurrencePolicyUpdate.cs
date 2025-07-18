using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicyUpdate))]
    public partial interface IRecurrencePolicyUpdate
    {
        long Version { get; set; }

        IList<IRecurrencePolicyUpdateAction> Actions { get; set; }

        IEnumerable<IRecurrencePolicyUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
