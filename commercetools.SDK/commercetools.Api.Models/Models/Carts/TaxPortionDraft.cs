using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxPortionDraft 
    {
        public string Name { get; set;}
        
        public double Rate { get; set;}
        
        public Money Amount { get; set;}
    }
}
