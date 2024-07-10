using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentReference : IPaymentReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IPayment Obj { get; set; }
        public PaymentReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment");
        }
    }
}
