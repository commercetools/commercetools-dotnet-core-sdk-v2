namespace commercetools.Api.Models.Products
{
    public partial class ProductSetAssetKeyAction : IProductSetAssetKeyAction
    {
        public string Action { get; set;}
        
        public long? VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool? Staged { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        public ProductSetAssetKeyAction()
        { 
           this.Action = "setAssetKey";
        }
    }
}
