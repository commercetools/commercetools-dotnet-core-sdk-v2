using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class MoneySetField : IMoneySetField
    {
        public string Type { get; set; }

        public IList<IMoney> Value { get; set; }
        public IEnumerable<IMoney> ValueEnumerable { set => Value = value.ToList(); }

        public MoneySetField()
        {
            this.Type = "MoneySet";
        }
    }
}
