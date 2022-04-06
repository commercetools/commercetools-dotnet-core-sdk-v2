using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
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
