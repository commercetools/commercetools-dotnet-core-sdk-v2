using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("centPrecision")]
    public class CentPrecisionMoneyDraft : TypedMoneyDraft
    {
    }
}
