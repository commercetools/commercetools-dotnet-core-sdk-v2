using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class RuleApprover : IRuleApprover
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }
    }
}
