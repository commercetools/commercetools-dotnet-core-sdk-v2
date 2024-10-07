using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentUpdate))]
    public partial interface IMyPaymentUpdate
    {
        long Version { get; set; }

        IList<IMyPaymentUpdateAction> Actions { get; set; }

        IEnumerable<IMyPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
