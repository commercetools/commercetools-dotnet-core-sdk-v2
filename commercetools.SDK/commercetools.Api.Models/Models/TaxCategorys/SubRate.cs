using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    public partial class SubRate 
    {
        public string Name { get; set;}
        
        public double Amount { get; set;}
    }
}
