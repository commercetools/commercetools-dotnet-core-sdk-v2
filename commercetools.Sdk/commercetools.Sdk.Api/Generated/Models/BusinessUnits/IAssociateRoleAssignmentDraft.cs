using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.AssociateRoleAssignmentDraft))]
    public partial interface IAssociateRoleAssignmentDraft
    {
        IAssociateRoleResourceIdentifier AssociateRole { get; set; }

    }
}
