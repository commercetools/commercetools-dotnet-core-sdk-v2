using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class ReorderApplicationAgreementUpdateAction : IReorderApplicationAgreementUpdateAction
    {
        public string Action { get; set; }

        public IList<string> AgreementIds { get; set; }

        public IEnumerable<string> AgreementIdsEnumerable { set => AgreementIds = value.ToList(); }
        public ReorderApplicationAgreementUpdateAction()
        {
            this.Action = "reorderAgreement";
        }
    }
}
