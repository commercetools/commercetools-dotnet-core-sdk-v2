using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Api.Models.Common.HighPrecisionMoneyDraft))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Api.Models.Common.CentPrecisionMoneyDraft))]
    public partial interface ITypedMoneyDraft : IMoney
    {
        string Type { get; set;}
        
        MoneyType TypeAsEnum { get; }
        
        int? FractionDigits { get; set;}
    }
}
