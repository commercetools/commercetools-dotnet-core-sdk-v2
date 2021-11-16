using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
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
