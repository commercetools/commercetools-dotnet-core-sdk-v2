using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField))]
    public partial interface IMoneySetField : ICustomField
    {
        IList<IMoney> Value { get; set; }
        IEnumerable<IMoney> ValueEnumerable { set => Value = value.ToList(); }


    }
}
