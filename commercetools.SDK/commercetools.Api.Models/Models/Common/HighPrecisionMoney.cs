using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("highPrecision")]
    public class HighPrecisionMoney : TypedMoney
    {
        public long PreciseAmount { get; set;}
    }
}
