using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetMaxApplicationsChange))]
    public partial interface ISetMaxApplicationsChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        int PreviousValue { get; set;}
        
        int NextValue { get; set;}
    }
}
