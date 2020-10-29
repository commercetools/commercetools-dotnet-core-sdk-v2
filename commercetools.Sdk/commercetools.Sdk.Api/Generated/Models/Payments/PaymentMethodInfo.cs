using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentMethodInfo : IPaymentMethodInfo
    {
        public string PaymentInterface { get; set;}
        
        public string Method { get; set;}
        
        public ILocalizedString Name { get; set;}
    }
}
