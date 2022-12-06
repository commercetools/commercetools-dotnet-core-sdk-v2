using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateUpdate))]
    public partial interface IStateUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IStateUpdate, IStateUpdateAction>
    {
        new long Version { get; set; }
        new IList<IStateUpdateAction> Actions { get; set; }
        IEnumerable<IStateUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
