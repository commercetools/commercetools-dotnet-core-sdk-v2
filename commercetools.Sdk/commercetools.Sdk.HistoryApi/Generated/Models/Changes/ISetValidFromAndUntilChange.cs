using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetValidFromAndUntilChange))]
    public partial interface ISetValidFromAndUntilChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IValidFromAndUntilValue PreviousValue { get; set;}
        
        IValidFromAndUntilValue NextValue { get; set;}
    }
}
