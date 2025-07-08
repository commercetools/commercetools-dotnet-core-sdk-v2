using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class MoneySetField : IMoneySetField
    {
        public string Type { get; set; }

        public IList<ITypedMoney> Value { get; set; }

        public IEnumerable<ITypedMoney> ValueEnumerable { set => Value = value.ToList(); }
        public MoneySetField()
        {
            this.Type = "MoneySet";
        }
    }
}
