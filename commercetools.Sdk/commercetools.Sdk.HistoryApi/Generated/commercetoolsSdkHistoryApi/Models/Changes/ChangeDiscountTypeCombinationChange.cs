using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeDiscountTypeCombinationChange : IChangeDiscountTypeCombinationChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountTypeCombination PreviousValue { get; set; }

        public IDiscountTypeCombination NextValue { get; set; }
        public ChangeDiscountTypeCombinationChange()
        {
            this.Type = "ChangeDiscountTypeCombinationChange";
        }
    }
}
