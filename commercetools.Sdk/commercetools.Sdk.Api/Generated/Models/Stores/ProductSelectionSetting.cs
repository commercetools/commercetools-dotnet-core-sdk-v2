using commercetools.Sdk.Api.Models.ProductSelections;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class ProductSelectionSetting : IProductSelectionSetting
    {
        public IProductSelectionReference ProductSelection { get; set; }

        public bool Active { get; set; }
    }
}
