using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateUpdate))]
    public partial interface IStateUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IStateUpdate, IStateUpdateAction>
    {
        new long Version { get; set; }
        new List<IStateUpdateAction> Actions { get; set; }

    }
}
