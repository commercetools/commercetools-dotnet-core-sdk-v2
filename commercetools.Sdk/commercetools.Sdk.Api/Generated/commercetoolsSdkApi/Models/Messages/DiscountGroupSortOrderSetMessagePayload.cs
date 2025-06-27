

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountGroupSortOrderSetMessagePayload : IDiscountGroupSortOrderSetMessagePayload
    {
        public string Type { get; set; }

        public string SortOrder { get; set; }

        public string OldSortOrder { get; set; }
        public DiscountGroupSortOrderSetMessagePayload()
        {
            this.Type = "DiscountGroupSortOrderSet";
        }
    }
}
