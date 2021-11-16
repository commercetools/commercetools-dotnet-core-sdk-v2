using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetSupplyChannelsChange))]
    public partial interface ISetSupplyChannelsChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        List<IReference> PreviousValue { get; set;}
        
        List<IReference> NextValue { get; set;}
    }
}
