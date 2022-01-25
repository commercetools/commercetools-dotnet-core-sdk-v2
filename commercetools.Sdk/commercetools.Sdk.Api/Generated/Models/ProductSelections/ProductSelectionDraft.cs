using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class ProductSelectionDraft : IProductSelectionDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }
    }
}
