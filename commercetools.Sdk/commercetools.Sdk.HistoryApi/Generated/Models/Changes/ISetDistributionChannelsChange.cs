using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDistributionChannelsChange))]
    public partial interface ISetDistributionChannelsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IReference> PreviousValue { get; set; }

        List<IReference> NextValue { get; set; }
    }
}
