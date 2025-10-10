using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationAgreementsUpdateAction : ISetApplicationAgreementsUpdateAction
    {
        public string Action { get; set; }

        public IList<IApplicationAgreementDraft> Agreements { get; set; }

        public IEnumerable<IApplicationAgreementDraft> AgreementsEnumerable { set => Agreements = value.ToList(); }
        public SetApplicationAgreementsUpdateAction()
        {
            this.Action = "setAgreements";
        }
    }
}
