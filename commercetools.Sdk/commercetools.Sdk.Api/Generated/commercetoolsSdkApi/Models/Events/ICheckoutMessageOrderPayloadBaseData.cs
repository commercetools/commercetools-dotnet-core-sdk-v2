using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Payments;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.CheckoutMessageOrderPayloadBaseData))]
    public partial interface ICheckoutMessageOrderPayloadBaseData
    {
        string ProjectKey { get; set; }

        ICartReference Cart { get; set; }

        IList<IPaymentReference> Payments { get; set; }

        IEnumerable<IPaymentReference> PaymentsEnumerable { set => Payments = value.ToList(); }

        IList<IErrorObject> Errors { get; set; }

        IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
