using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class TaxPortionDraft 
    {
        public string Name { get; set;}
        
        public double Rate { get; set;}
        
        public Money Amount { get; set;}
    }
}
