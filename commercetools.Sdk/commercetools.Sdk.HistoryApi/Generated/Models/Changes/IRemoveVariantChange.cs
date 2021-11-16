using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveVariantChange))]
    public partial interface IRemoveVariantChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string CatalogData { get; set;}
        
        IVariant PreviousValue { get; set;}
        
        IVariant NextValue { get; set;}
    }
}
