

namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class AssociateRoleLabel : IAssociateRoleLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }
        public AssociateRoleLabel()
        {
            this.Type = "AssociateRoleLabel";
        }
    }
}
