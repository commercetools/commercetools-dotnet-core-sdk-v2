using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentUpdate))]
    public partial interface IPaymentUpdate
    {
        new long Version { get; set; }
        new IList<IPaymentUpdateAction> Actions { get; set; }
        IEnumerable<IPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
