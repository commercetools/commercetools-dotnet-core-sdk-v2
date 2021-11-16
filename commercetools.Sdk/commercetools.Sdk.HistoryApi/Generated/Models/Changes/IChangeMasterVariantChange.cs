using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeMasterVariantChange))]
    public partial interface IChangeMasterVariantChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string CatalogData { get; set;}
        
        IVariant PreviousValue { get; set;}
        
        IVariant NextValue { get; set;}
    }
}
