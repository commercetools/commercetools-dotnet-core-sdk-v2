using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue))]
    public partial interface IChangeValueAbsoluteChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        List<IMoney> Money { get; set; }
    }
}
