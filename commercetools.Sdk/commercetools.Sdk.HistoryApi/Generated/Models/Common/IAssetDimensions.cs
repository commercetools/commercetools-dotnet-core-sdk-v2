using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.AssetDimensions))]
    public partial interface IAssetDimensions 
    {
        int W { get; set;}
        
        int H { get; set;}
    }
}
