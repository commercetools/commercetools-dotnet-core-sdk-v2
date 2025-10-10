using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementsUpdateAction))]
    public partial interface ISetApplicationAgreementsUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IList<IApplicationAgreementDraft> Agreements { get; set; }

        IEnumerable<IApplicationAgreementDraft> AgreementsEnumerable { set => Agreements = value.ToList(); }

    }
}
