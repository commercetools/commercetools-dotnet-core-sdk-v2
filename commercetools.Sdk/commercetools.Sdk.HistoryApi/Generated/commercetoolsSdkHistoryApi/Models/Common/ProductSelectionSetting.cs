

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductSelectionSetting : IProductSelectionSetting
    {
        public IProductSelectionReference ProductSelection { get; set; }

        public bool Active { get; set; }
    }
}
