using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodUpdate))]
    public partial interface IPaymentMethodUpdate
    {
        long Version { get; set; }

        IList<IPaymentMethodUpdateAction> Actions { get; set; }

        IEnumerable<IPaymentMethodUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
