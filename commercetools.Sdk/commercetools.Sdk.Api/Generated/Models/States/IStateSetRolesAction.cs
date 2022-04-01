using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateSetRolesAction))]
    public partial interface IStateSetRolesAction : IStateUpdateAction
    {
        List<IStateRoleEnum> Roles { get; set; }
    }
}
