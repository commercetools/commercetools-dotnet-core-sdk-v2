using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentUpdate : IPaymentUpdate
    {
        public long Version { get; set; }

        public IList<IPaymentUpdateAction> Actions { get; set; }
        public IEnumerable<IPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
