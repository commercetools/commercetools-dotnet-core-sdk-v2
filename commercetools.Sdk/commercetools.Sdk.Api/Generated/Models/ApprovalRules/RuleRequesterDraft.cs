using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class RuleRequesterDraft : IRuleRequesterDraft
    {
        public IAssociateRoleResourceIdentifier AssociateRole { get; set; }
    }
}
