using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateRemoveRolesAction))]
    public partial interface IStateRemoveRolesAction : IStateUpdateAction
    {
        List<IStateRoleEnum> Roles { get; set;}
    }
}
