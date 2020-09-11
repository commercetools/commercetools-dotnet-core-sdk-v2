using commercetools.Api.Models.Common;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(HighPrecisionMoneyDraft), "highPrecision")]
    [JsonSubtypes.KnownSubType(typeof(CentPrecisionMoneyDraft), "centPrecision")]
    public abstract class TypedMoneyDraft : Money
    {
        public MoneyType Type { get; set;}
    }
}
