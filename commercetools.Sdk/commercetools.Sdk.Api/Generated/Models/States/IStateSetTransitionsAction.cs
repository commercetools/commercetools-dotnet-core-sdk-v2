using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateSetTransitionsAction))]
    public partial interface IStateSetTransitionsAction : IStateUpdateAction
    {
        List<IStateResourceIdentifier> Transitions { get; set; }

    }
}
