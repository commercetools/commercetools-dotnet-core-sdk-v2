using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeLocalizedDescriptionChange))]
    public partial interface IChangeLocalizedDescriptionChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILocalizedString PreviousValue { get; set;}
        
        ILocalizedString NextValue { get; set;}
    }
}
