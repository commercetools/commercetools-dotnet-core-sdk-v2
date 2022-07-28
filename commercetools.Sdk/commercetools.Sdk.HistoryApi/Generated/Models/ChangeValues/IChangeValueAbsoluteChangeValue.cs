using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue))]
    public partial interface IChangeValueAbsoluteChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        List<IMoney> Money { get; set; }

    }
}
