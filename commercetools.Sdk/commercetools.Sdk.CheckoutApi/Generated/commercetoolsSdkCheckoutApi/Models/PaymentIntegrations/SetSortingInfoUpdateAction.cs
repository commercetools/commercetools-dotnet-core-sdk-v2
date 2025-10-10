

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetSortingInfoUpdateAction : ISetSortingInfoUpdateAction
    {
        public string Action { get; set; }

        public ISortingInfo SortingInfo { get; set; }
        public SetSortingInfoUpdateAction()
        {
            this.Action = "setSortingInfo";
        }
    }
}
