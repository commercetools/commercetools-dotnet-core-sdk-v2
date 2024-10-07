using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class InheritedAssociateRoleAssignment : IInheritedAssociateRoleAssignment
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }

        public IBusinessUnitKeyReference Source { get; set; }
    }
}
