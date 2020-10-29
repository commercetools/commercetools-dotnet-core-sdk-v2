using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentUpdate : IPaymentUpdate
    {
        public long Version { get; set;}
        
        public List<IPaymentUpdateAction> Actions { get; set;}
    }
}
