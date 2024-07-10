namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class InheritedAssociateRoleAssignment : IInheritedAssociateRoleAssignment
    {
        public IKeyReference AssociateRole { get; set; }

        public IKeyReference Source { get; set; }
    }
}
