using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class PriceTierDraft 
    {
        public long MinimumQuantity { get; set;}
        
        public Money Value { get; set;}
    }
}
