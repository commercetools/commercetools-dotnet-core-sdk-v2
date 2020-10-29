using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartChangeTaxCalculationModeAction))]
    public interface ICartChangeTaxCalculationModeAction : ICartUpdateAction
    {
        string TaxCalculationMode { get; set;}
        
        TaxCalculationMode TaxCalculationModeAsEnum { get; }
    }
}
