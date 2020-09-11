using commercetools.Api.Models.Common;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CentPrecisionMoney), "centPrecision")]
    [JsonSubtypes.KnownSubType(typeof(HighPrecisionMoney), "highPrecision")]
    public abstract class TypedMoney 
    {
        public MoneyType Type { get; set;}
        
        public int FractionDigits { get; set;}
        
        public long CentAmount { get; set;}
        
        public string CurrencyCode { get; set;}
    }
}
