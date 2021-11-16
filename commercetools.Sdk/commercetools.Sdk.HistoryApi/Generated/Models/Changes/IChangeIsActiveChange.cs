using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeIsActiveChange))]
    public partial interface IChangeIsActiveChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        bool PreviousValue { get; set;}
        
        bool NextValue { get; set;}
    }
}
