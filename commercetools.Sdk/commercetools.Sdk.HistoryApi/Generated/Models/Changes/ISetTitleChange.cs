using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetTitleChange))]
    public partial interface ISetTitleChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string PreviousValue { get; set;}
        
        string NextValue { get; set;}
    }
}
