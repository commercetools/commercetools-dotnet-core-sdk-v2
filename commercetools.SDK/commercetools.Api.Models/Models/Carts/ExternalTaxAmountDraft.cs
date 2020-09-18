using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class ExternalTaxAmountDraft 
    {
        public Money TotalGross { get; set;}
        
        public ExternalTaxRateDraft TaxRate { get; set;}
    }
}
