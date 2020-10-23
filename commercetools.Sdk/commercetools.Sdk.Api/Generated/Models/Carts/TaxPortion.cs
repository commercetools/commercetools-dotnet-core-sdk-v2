using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set;}
        
        public double Rate { get; set;}
        
        public ITypedMoney Amount { get; set;}
    }
}
