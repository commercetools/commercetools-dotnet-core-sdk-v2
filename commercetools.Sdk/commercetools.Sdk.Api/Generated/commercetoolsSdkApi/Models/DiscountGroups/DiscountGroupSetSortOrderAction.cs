

namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupSetSortOrderAction : IDiscountGroupSetSortOrderAction
    {
        public string Action { get; set; }

        public string SortOrder { get; set; }
        public DiscountGroupSetSortOrderAction()
        {
            this.Action = "setSortOrder";
        }
    }
}
