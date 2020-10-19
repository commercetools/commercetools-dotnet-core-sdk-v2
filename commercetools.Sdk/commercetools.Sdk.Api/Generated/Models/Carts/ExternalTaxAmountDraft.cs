using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class ExternalTaxAmountDraft 
    {
        public Money TotalGross { get; set;}
        
        public ExternalTaxRateDraft TaxRate { get; set;}
    }
}
