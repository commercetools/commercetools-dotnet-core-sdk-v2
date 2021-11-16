using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.AssetDimensions))]
    public partial interface IAssetDimensions 
    {
        int W { get; set;}
        
        int H { get; set;}
    }
}
