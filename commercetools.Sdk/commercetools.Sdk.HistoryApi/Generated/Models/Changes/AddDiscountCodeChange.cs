using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class AddDiscountCodeChange : IAddDiscountCodeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountCodeInfo NextValue { get; set; }
        public AddDiscountCodeChange()
        {
            this.Type = "AddDiscountCodeChange";
        }
    }
}
