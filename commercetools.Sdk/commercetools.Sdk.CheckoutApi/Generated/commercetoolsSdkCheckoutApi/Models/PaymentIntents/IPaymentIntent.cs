using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntent))]
    public partial interface IPaymentIntent
    {
        IList<IPaymentIntentAction> Actions { get; set; }

        IEnumerable<IPaymentIntentAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
