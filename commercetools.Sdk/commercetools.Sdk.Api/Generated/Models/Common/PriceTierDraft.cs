using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public  partial class PriceTierDraft : IPriceTierDraft
    {
        public long MinimumQuantity { get; set;}
        
        public IMoney Value { get; set;}
    }
}
