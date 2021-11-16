using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddLocationChange))]
    public partial interface IAddLocationChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILocation PreviousValue { get; set;}
        
        ILocation NextValue { get; set;}
    }
}
