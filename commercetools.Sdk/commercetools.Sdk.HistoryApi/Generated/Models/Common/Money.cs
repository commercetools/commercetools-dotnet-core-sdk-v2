using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class Money : IMoney
    {
        public string CurrencyCode { get; set;}
        
        public int CentAmount { get; set;}
        
        public int FractionDigits { get; set;}
        
        public IMoneyType Type { get; set;}
    }
}
