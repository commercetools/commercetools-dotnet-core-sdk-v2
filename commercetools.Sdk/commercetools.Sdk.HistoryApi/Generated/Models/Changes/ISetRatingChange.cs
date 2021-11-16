using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetRatingChange))]
    public partial interface ISetRatingChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        int PreviousValue { get; set;}
        
        int NextValue { get; set;}
    }
}
