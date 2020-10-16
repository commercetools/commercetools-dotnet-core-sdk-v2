using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Common
{
    public partial class PriceTierDraft 
    {
        public long MinimumQuantity { get; set;}
        
        public Money Value { get; set;}
    }
}
