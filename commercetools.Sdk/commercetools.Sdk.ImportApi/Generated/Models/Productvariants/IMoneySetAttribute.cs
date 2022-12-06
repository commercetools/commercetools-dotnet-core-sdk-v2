using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute))]
    public partial interface IMoneySetAttribute : IAttribute
    {
        IList<ITypedMoney> Value { get; set; }
        IEnumerable<ITypedMoney> ValueEnumerable { set => Value = value.ToList(); }


    }
}
