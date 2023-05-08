using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.InheritedAssociateRoleAssignment))]
    public partial interface IInheritedAssociateRoleAssignment
    {
        IAssociateRoleKeyReference AssociateRole { get; set; }

        IBusinessUnitKeyReference Source { get; set; }

    }
}
