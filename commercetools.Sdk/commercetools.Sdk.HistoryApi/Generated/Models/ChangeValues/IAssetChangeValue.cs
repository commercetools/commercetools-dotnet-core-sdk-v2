using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.AssetChangeValue))]
    public partial interface IAssetChangeValue 
    {
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
    }
}
