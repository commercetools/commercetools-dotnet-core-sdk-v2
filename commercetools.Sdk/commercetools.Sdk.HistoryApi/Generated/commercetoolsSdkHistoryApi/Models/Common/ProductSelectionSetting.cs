

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductSelectionSetting : IProductSelectionSetting
    {
        public IReference ProductSelection { get; set; }

        public bool Active { get; set; }
    }
}
