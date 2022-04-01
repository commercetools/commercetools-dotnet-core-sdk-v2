namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductCatalogData : IProductCatalogData
    {
        public bool Published { get; set; }

        public IProductData Current { get; set; }

        public IProductData Staged { get; set; }

        public bool HasStagedChanges { get; set; }
    }
}
