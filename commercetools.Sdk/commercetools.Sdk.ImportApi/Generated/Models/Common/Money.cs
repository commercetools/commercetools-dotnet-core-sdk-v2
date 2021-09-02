using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class Money : IMoney
    {
        public IMoneyType Type { get; set; }

        public int? FractionDigits { get; set; }

        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }
        public Money()
        {
            this.Type = IMoneyType.FindEnum("centPrecision");
        }
    }
}
