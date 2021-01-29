using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.ImportApi.Models.Common.HighPrecisionMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.ImportApi.Models.Common.Money))]
    public partial interface ITypedMoney 
    {
        IMoneyType Type { get; set;}
        
        int? FractionDigits { get; set;}
        
        long CentAmount { get; set;}
        
        string CurrencyCode { get; set;}
    }
}
