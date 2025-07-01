using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupSetNameAction : IDiscountGroupSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public DiscountGroupSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
