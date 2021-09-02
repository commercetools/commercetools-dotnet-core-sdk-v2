using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class MoneySetAttribute : IMoneySetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<ITypedMoney> Value { get; set; }
        public MoneySetAttribute()
        {
            this.Type = "money-set";
        }
    }
}
