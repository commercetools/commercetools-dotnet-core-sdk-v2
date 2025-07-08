using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField))]
    public partial interface IMoneySetField : ICustomField
    {
        IList<ITypedMoney> Value { get; set; }

        IEnumerable<ITypedMoney> ValueEnumerable { set => Value = value.ToList(); }

    }
}
