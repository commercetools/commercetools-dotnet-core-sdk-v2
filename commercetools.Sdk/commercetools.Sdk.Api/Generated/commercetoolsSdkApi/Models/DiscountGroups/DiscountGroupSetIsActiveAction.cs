

namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupSetIsActiveAction : IDiscountGroupSetIsActiveAction
    {
        public string Action { get; set; }

        public bool IsActive { get; set; }
        public DiscountGroupSetIsActiveAction()
        {
            this.Action = "setIsActive";
        }
    }
}
