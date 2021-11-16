using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Prices
{
    public partial class SubRate : ISubRate
    {
        public string Name { get; set;}
        
        public double Amount { get; set;}
    }
}
