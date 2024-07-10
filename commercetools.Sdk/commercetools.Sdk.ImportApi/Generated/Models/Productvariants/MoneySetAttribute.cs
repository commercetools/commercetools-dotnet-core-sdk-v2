using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class MoneySetAttribute : IMoneySetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<ITypedMoney> Value { get; set; }
        public IEnumerable<ITypedMoney> ValueEnumerable { set => Value = value.ToList(); }

        public MoneySetAttribute()
        {
            this.Type = "money-set";
        }
    }
}
