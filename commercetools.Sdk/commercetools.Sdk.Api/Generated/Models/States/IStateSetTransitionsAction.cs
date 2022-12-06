using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateSetTransitionsAction))]
    public partial interface IStateSetTransitionsAction : IStateUpdateAction
    {
        IList<IStateResourceIdentifier> Transitions { get; set; }
        IEnumerable<IStateResourceIdentifier> TransitionsEnumerable { set => Transitions = value.ToList(); }


    }
}
