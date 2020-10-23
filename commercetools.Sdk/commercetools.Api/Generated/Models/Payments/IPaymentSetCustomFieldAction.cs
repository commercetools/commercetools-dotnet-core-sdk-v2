using commercetools.Api.Generated.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPaymentSetCustomFieldAction : IPaymentUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
