using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("highPrecision")]
    public partial class HighPrecisionMoney : TypedMoney
    {
        public long PreciseAmount { get; set;}
        public HighPrecisionMoney()
        { 
           this.Type = "highPrecision";
        }
    }
}
