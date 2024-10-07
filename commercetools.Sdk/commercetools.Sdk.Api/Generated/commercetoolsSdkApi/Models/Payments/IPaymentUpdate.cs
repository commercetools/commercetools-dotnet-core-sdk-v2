using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentUpdate))]
    public partial interface IPaymentUpdate
    {
        long Version { get; set; }

        IList<IPaymentUpdateAction> Actions { get; set; }

        IEnumerable<IPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
