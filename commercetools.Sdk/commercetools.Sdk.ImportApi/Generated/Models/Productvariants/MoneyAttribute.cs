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

    public partial class MoneyAttribute : IMoneyAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public ITypedMoney Value { get; set; }
        public MoneyAttribute()
        {
            this.Type = "money";
        }
    }
}
