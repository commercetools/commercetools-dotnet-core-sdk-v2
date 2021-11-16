using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetFirstNameChange))]
    public partial interface ISetFirstNameChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string PreviousValue { get; set;}
        
        string NextValue { get; set;}
    }
}
