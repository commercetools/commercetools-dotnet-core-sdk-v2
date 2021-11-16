using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.UnpublishChange))]
    public partial interface IUnpublishChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
    }
}
