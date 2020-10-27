using commercetools.Api.Models.Payments;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentTransitionStateAction))]
    public interface IPaymentTransitionStateAction : IPaymentUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool? Force { get; set;}
    }
}
