using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class HighPrecisionMoneyDraft : TypedMoneyDraft
    {
        public long PreciseAmount { get; set;}
    }
}
