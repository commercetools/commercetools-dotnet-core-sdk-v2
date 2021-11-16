using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateAddRolesAction))]
    public partial interface IStateAddRolesAction : IStateUpdateAction
    {
        List<IStateRoleEnum> Roles { get; set;}
    }
}
