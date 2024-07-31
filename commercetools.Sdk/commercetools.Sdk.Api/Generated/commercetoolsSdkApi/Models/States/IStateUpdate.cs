using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateUpdate))]
    public partial interface IStateUpdate
    {
        long Version { get; set; }

        IList<IStateUpdateAction> Actions { get; set; }

        IEnumerable<IStateUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
