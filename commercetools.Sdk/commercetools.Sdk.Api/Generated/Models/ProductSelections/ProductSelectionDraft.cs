using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class ProductSelectionDraft : IProductSelectionDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
