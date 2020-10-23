using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPaymentMethodInfo 
    {
        string PaymentInterface { get; set;}
        
        string Method { get; set;}
        
        ILocalizedString Name { get; set;}
    }
}
