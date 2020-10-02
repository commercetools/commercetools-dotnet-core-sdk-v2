using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("centPrecision")]
    public partial class CentPrecisionMoneyDraft : TypedMoneyDraft
    {
        public CentPrecisionMoneyDraft()
        { 
           this.Type = "centPrecision";
        }
    }
}
