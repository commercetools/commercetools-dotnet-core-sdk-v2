using commercetools.Api.Generated.Models.Payments;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPaymentTransitionStateAction : IPaymentUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool Force { get; set;}
    }
}
