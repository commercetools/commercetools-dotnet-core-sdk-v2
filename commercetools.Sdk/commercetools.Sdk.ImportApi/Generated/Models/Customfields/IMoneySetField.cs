using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.MoneySetField))]
    public partial interface IMoneySetField : ICustomField
    {
        List<IMoney> Value { get; set;}
    }
}
