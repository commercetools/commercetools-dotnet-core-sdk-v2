

namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupSetKeyAction : IDiscountGroupSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public DiscountGroupSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
