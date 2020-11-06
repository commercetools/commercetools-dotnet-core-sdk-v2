using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentUpdate))]
    public partial interface IMyPaymentUpdate 
    {
        long Version { get; set;}
        
        List<IMyPaymentUpdateAction> Actions { get; set;}
    }
}
