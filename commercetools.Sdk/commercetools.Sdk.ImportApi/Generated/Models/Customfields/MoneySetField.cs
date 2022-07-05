using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class MoneySetField : IMoneySetField
    {
        public string Type { get; set; }

        public List<IMoney> Value { get; set; }
        public MoneySetField()
        {
            this.Type = "MoneySet";
        }
    }
}
