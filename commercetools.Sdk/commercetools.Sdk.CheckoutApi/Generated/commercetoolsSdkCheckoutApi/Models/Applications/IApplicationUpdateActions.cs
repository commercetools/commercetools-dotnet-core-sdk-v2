using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationUpdateActions))]
    public partial interface IApplicationUpdateActions
    {
        int Version { get; set; }

        IList<IApplicationUpdateAction> Actions { get; set; }

        IEnumerable<IApplicationUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
