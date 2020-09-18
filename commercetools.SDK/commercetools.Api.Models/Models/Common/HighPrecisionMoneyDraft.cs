using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("highPrecision")]
    public class HighPrecisionMoneyDraft : TypedMoneyDraft
    {
        public long PreciseAmount { get; set;}
    }
}
