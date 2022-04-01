using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateUpdate))]
    public partial interface IStateUpdate
    {
        long Version { get; set; }

        List<IStateUpdateAction> Actions { get; set; }
    }
}
