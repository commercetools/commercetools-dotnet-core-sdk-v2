using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddProductChange : IAddProductChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference NextValue { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }
        public AddProductChange()
        {
            this.Type = "AddProductChange";
        }
    }
}
