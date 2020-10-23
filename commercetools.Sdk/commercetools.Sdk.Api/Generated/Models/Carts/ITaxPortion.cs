using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.TaxPortion))]
    public interface ITaxPortion 
    {
        string Name { get; set;}
        
        double Rate { get; set;}
        
        ITypedMoney Amount { get; set;}
    }
}
