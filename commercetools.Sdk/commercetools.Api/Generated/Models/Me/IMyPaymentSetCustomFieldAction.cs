using commercetools.Api.Generated.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyPaymentSetCustomFieldAction : IMyPaymentUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
