using commercetools.Api.Models.ProductSelections;


namespace commercetools.Api.Models.Stores
{
    public partial class ProductSelectionSetting : IProductSelectionSetting
    {
        public IProductSelectionReference ProductSelection { get; set; }

        public bool Active { get; set; }
    }
}
