using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Api.Models.Common.HighPrecisionMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Api.Models.Common.CentPrecisionMoney))]
    public partial interface ITypedMoney 
    {
        string Type { get; set;}
        
        MoneyType TypeAsEnum { get; }
        
        int FractionDigits { get; set;}
        
        long CentAmount { get; set;}
        
        string CurrencyCode { get; set;}
    }
}
