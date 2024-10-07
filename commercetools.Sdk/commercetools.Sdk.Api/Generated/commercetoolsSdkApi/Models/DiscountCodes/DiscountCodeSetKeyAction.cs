

namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetKeyAction : IDiscountCodeSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public DiscountCodeSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
