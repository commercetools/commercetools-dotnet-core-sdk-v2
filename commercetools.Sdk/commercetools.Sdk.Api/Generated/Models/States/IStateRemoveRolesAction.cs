using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateRemoveRolesAction))]
    public partial interface IStateRemoveRolesAction : IStateUpdateAction
    {
        List<IStateRoleEnum> Roles { get; set; }
    }
}
