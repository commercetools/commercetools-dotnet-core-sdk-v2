using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ReorderApplicationAgreementUpdateAction))]
    public partial interface IReorderApplicationAgreementUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IList<string> AgreementIds { get; set; }

        IEnumerable<string> AgreementIdsEnumerable { set => AgreementIds = value.ToList(); }

    }
}
