using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeChangeGroupsAction : IDiscountCodeChangeGroupsAction
    {
        public string Action { get; set; }

        public IList<string> Groups { get; set; }
        public IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }

        public DiscountCodeChangeGroupsAction()
        {
            this.Action = "changeGroups";
        }
    }
}
