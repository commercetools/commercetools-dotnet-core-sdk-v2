using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Common.TypedMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Api.Models.Common.CentPrecisionMoney))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Api.Models.Common.HighPrecisionMoney))]
    public partial interface ITypedMoney 
    {
        IMoneyType Type { get; set;}
        
        int FractionDigits { get; set;}
        
        long CentAmount { get; set;}
        
        string CurrencyCode { get; set;}
    }
}
