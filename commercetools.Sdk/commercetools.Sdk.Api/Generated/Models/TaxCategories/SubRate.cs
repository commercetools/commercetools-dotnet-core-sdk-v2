using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public  partial class SubRate : ISubRate
    {
        public string Name { get; set;}
        
        public double Amount { get; set;}
    }
}
