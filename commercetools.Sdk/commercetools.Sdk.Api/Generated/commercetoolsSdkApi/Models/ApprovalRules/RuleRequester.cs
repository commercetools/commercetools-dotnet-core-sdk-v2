using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class RuleRequester : IRuleRequester
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }
    }
}
