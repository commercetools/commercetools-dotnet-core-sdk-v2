using commercetools.Sdk.Api.Models.ProductSelections;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class ProductSelectionSettingDraft : IProductSelectionSettingDraft
    {
        public IProductSelectionResourceIdentifier ProductSelection { get; set; }

        public bool? Active { get; set; }
    }
}
