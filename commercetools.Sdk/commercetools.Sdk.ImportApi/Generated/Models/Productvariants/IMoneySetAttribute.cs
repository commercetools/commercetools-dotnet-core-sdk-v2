using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.MoneySetAttribute))]
    public partial interface IMoneySetAttribute : IAttribute
    {
        List<ITypedMoney> Value { get; set; }
    }
}
