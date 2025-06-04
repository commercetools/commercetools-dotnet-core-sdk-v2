using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Payments;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class CheckoutMessageOrderPayloadBaseData : ICheckoutMessageOrderPayloadBaseData
    {
        public string ProjectKey { get; set; }

        public ICartReference Cart { get; set; }

        public IList<IPaymentReference> Payments { get; set; }

        public IEnumerable<IPaymentReference> PaymentsEnumerable { set => Payments = value.ToList(); }

        public IList<IErrorObject> Errors { get; set; }

        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
