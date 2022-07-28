using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute))]
    public partial interface IMoneySetAttribute : IAttribute
    {
        List<ITypedMoney> Value { get; set; }

    }
}
